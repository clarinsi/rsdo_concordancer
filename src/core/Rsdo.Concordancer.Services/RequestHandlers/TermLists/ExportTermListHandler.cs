using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Constants;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.Core.Search.Queries.TermLists;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.Services.Framework.DbContext;
using Rsdo.Concordancer.Services.Search.QueryFactories;

namespace Rsdo.Concordancer.Services.RequestHandlers.TermLists;

public class ExportTermListHandler : BaseSearchTermListHandler, IRequestHandler<ExportTermList, ExportTermListResponse>
{
    private readonly IQueryFactory<ExportTermList, TermListQuery> queryFactory;
    private readonly ISearchEngine searchEngine;

    public ExportTermListHandler(CorpusDbContext dbContext, IQueryFactory<ExportTermList, TermListQuery> queryFactory, ISearchEngine searchEngine)
        : base(dbContext)
    {
        this.queryFactory = queryFactory;
        this.searchEngine = searchEngine;
    }

    public async Task<ExportTermListResponse> Handle(ExportTermList request, CancellationToken cancellationToken)
    {
        // Convert request to search query
        var query = await queryFactory.GetQuery(request);

        // Execute search
        var result = await searchEngine.Search<Term, TermListQuery>(query);

        // Get search items
        var items = await GetItems(result.EntityIds);

        // Export
        var stream = new MemoryStream();
        await using (var writer = new StreamWriter(stream, Encoding.UTF8, 1024, true))
        {
            // Writer header
            await WriteHeader(writer);

            // Write items
            foreach (var item in items)
            {
                await WriteItem(writer, item);
            }
        }

        stream.Position = 0;
        return new ExportTermListResponse()
        {
            ContentType = Constants.Export.DefaultContentType,
            FileName = "export.txt",
            Stream = stream,
        };
    }

    private static async Task WriteHeader(StreamWriter writer)
    {
        await writer.WriteAsync("Termin");
        await writer.WriteAsync("\t");
        await writer.WriteAsync("Osnovna oblika");
        await writer.WriteAsync("\t");
        await writer.WriteAsync("Število pojavitev");
        await writer.WriteLineAsync();
    }

    private static async Task WriteItem(StreamWriter writer, SearchTermListResponseItem item)
    {
        await writer.WriteAsync(item.Form);
        await writer.WriteAsync("\t");
        await writer.WriteAsync(item.Lemma);
        await writer.WriteAsync("\t");
        await writer.WriteAsync(item.Frequency.ToString());
        await writer.WriteLineAsync();
    }
}