using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rsdo.Concordancer.Core.Constants;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Core.Model;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.Core.Search.Queries.Concordances;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;
using Rsdo.Concordancer.Services.Search.QueryFactories;
using Rsdo.Concordancer.Services.Services.ParagraphService;

namespace Rsdo.Concordancer.Services.RequestHandlers.Concordances;

public class ExportConcordancesHandler : BaseSearchConcordancesHandler, IRequestHandler<ExportConcordances, ExportConcordancesResponse>
{
    private readonly CorpusDbContext dbContext;
    private readonly IQueryFactory<ExportConcordances, ConcordancesQuery> queryFactory;
    private readonly ISearchEngine searchEngine;

    public ExportConcordancesHandler(
        CorpusDbContext dbContext,
        IParagraphService paragraphService,
        IQueryFactory<ExportConcordances, ConcordancesQuery> queryFactory,
        ISearchEngine searchEngine)
        : base(paragraphService)
    {
        this.dbContext = dbContext;
        this.queryFactory = queryFactory;
        this.searchEngine = searchEngine;
    }

    public async Task<ExportConcordancesResponse> Handle(ExportConcordances request, CancellationToken cancellationToken)
    {
        // Convert request to search query
        var query = await queryFactory.GetQuery(request);

        // Execute search
        var result = await searchEngine.Search<Concordance, ConcordancesQuery>(query);

        // Get search items
        var items = await GetItems(query, result.EntityIds);

        // Get sources
        var sources = await GetSources(items);

        // Export
        var stream = new MemoryStream();
        await using (var writer = new StreamWriter(stream, Encoding.UTF8, 1024, true))
        {
            // Writer header
            await WriteHeader(writer);

            // Write items
            foreach (var item in items)
            {
                await WriteItem(writer, item, sources[item.ParagraphId]);
            }
        }

        stream.Position = 0;
        return new ExportConcordancesResponse()
        {
            ContentType = Constants.Export.DefaultContentType,
            FileName = "export.txt",
            Stream = stream,
        };
    }

    private static async Task WriteContext(StreamWriter writer, List<ConcordanceToken> tokens)
    {
        if (tokens != null)
        {
            foreach (var token in tokens)
            {
                switch (token.Type)
                {
                    case TokenType.Word or TokenType.PunctuationCharacter:
                        await writer.WriteAsync(token.Form);
                        break;
                    case TokenType.Character:
                        await writer.WriteAsync(" ");
                        break;
                }
            }
        }
    }

    private static async Task WriteHeader(StreamWriter writer)
    {
        await writer.WriteAsync("Levo besedilo");
        await writer.WriteAsync("\t");
        await writer.WriteAsync("Iskani niz");
        await writer.WriteAsync("\t");
        await writer.WriteAsync("Desno besedilo");
        await writer.WriteAsync("\t");
        await writer.WriteAsync("Vir");
        await writer.WriteLineAsync();
    }

    private static async Task WriteItem(StreamWriter writer, SearchConcordancesResponseItem item, string source)
    {
        await WriteContext(writer, item.LeftContext);
        await writer.WriteAsync("\t");
        await writer.WriteAsync(item.CenterContext.Form);
        await writer.WriteAsync("\t");
        await WriteContext(writer, item.RightContext);
        await writer.WriteAsync("\t");
        await writer.WriteAsync(source);
        await writer.WriteLineAsync();
    }

    private async Task<Dictionary<Guid, string>> GetSources(List<SearchConcordancesResponseItem> items)
    {
        var paragraphIds = items.Select(i => i.ParagraphId).ToList();
        var sources = await dbContext.Paragraph.Include(p => p.Text)
            .Where(p => paragraphIds.Contains(p.Id))
            .Select(
                p => new
                {
                    p.Id,
                    p.Text.SourceFile,
                })
            .ToListAsync();
        return sources.ToDictionary(x => x.Id, x => Path.GetFileNameWithoutExtension(x.SourceFile));
    }
}