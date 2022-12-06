using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Exceptions;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.ServiceModel.Requests.Corpuses;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DatabaseManager;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.RequestHandlers.Corpuses;

public class CreateCorpusStoreHandler : IRequestHandler<CreateCorpusStore, ExecutionResult>
{
    private readonly IDatabaseManager databaseManager;
    private readonly MasterDbContext dbContext;
    private readonly ISearchEngine searchEngine;

    public CreateCorpusStoreHandler(IDatabaseManager databaseManager, MasterDbContext dbContext, ISearchEngine searchEngine)
    {
        this.databaseManager = databaseManager;
        this.dbContext = dbContext;
        this.searchEngine = searchEngine;
    }

    public async Task<ExecutionResult> Handle(CreateCorpusStore request, CancellationToken cancellationToken)
    {
        // Get corpus
        var corpus = await dbContext.Corpus.SingleAsync(x => x.Id == request.CorpusId, cancellationToken);

        // Check corpus status
        if (corpus.Status != CorpusStatus.Creating)
        {
            throw new XForbiddenException(Errors.Forbidden.CorpusStatusIsNotValid(corpus.Status, CorpusStatus.Creating));
        }

        // Create database for corpus
        var createDbTask = databaseManager.CreateCorpusDatabase();

        // Create elastic indexes
        var createSchemaTask = searchEngine.CreateSchema();

        // Wait to finish
        await Task.WhenAll(createDbTask, createSchemaTask);

        // Mark corpus as active
        corpus.Status = CorpusStatus.Active;
        await dbContext.SaveChangesAsync(cancellationToken);

        // Return result
        return new ExecutionResult();
    }
}