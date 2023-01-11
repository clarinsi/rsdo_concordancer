using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.BulkLoaders;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.TermLists;

public class ImportTermListHandler : IRequestHandler<ImportTermList, ExecutionResult>
{
    private readonly IBulkLoader bulkLoader;
    private readonly CorpusDbContext dbContext;
    private readonly IServiceBus serviceBus;

    public ImportTermListHandler(IBulkLoader bulkLoader, CorpusDbContext dbContext, IServiceBus serviceBus)
    {
        this.bulkLoader = bulkLoader;
        this.dbContext = dbContext;
        this.serviceBus = serviceBus;
    }

    public async Task<ExecutionResult> Handle(ImportTermList request, CancellationToken cancellationToken)
    {
        // Get term list
        // Dont track term list since the data is imported with bulk loading and that would cause duplicate entities to be inserted
        var termList = await dbContext.TermList.AsNoTracking().SingleOrDefaultAsync(t => t.Id == request.TermListId, cancellationToken);
        if (termList == null)
        {
            throw new XNotFoundException(Errors.NotFound.EntityNotFound(EntityType.TermList, request.TermListId));
        }

        // Check if file exists
        if (!File.Exists(termList.SourceFile))
        {
            throw new FileNotFoundException(Errors.NotFound.FileNotFound(termList.SourceFile), termList.SourceFile);
        }

        try
        {
            // Change status to importing
            await ChangeStatus(termList, ImportStatus.Importing, cancellationToken);

            // Import term list
            await ImportTermList(termList, cancellationToken);

            // Bulk load data into database
            await SaveTermListWithBulkLoading(termList, cancellationToken);

            // Send job to index term list
            await serviceBus.Send(
                new IndexTermList()
                {
                    CorpusId = request.CorpusId,
                    TermListId = termList.Id,
                });

            // Change status to importing completed
            await ChangeStatus(termList, ImportStatus.ImportingCompleted, cancellationToken);

            return new ExecutionResult();
        }
        catch (Exception)
        {
            await ChangeStatus(termList, ImportStatus.ImportingFaulted, cancellationToken);
            throw;
        }
    }

    private static async Task ImportTermList(TermList termList, CancellationToken cancellationToken)
    {
        var lastPropertyName = string.Empty;
        var inTerms = false;

        await using var stream = new FileStream(termList.SourceFile, FileMode.Open, FileAccess.Read);
        using var streamReader = new StreamReader(stream);
        using var jsonReader = new JsonTextReader(streamReader);
        while (await jsonReader.ReadAsync(cancellationToken))
        {
            switch (jsonReader.TokenType)
            {
                case JsonToken.PropertyName:
                    lastPropertyName = jsonReader.Value.ToString();
                    break;
                case JsonToken.StartArray when lastPropertyName == "terminoloski_kandidati":
                    inTerms = true;
                    break;
                case JsonToken.EndArray when inTerms:
                    inTerms = false;
                    break;
                case JsonToken.StartObject when inTerms:
                {
                    var termObj = await JObject.LoadAsync(jsonReader, cancellationToken);
                    var term = new Term()
                    {
                        Form = termObj["kanonicnaoblika"].Value<string>(),
                        Lemma = termObj["kandidat"].Value<string>(),
                        Msd = termObj["POSoznake"].Value<string>(),
                        Weight = termObj["ranking"].Value<decimal>(),
                        Frequency = termObj["pogostostpojavljanja"].Values<int>().First(),
                        TermListAutoId = termList.AutoId,
                    }.ApplyCreateValues();

                    termList.Terms ??= new List<Term>();
                    termList.Terms.Add(term);
                    break;
                }
            }
        }
    }

    private async Task SaveTermListWithBulkLoading(TermList termList, CancellationToken cancellationToken)
    {
        if (termList.Terms.IsNullOrEmpty())
        {
            return;
        }

        await bulkLoader.InsertEntities(termList.Terms, false, cancellationToken);
    }

    private async Task ChangeStatus(TermList termList, ImportStatus newStatus, CancellationToken cancellationToken)
    {
        termList.Status = newStatus;
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}