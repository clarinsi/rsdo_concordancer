using System.Threading;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.Core.Search.Queries.TermLists;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.Services.Framework.DbContext;
using Rsdo.Concordancer.Services.Search.QueryFactories;

namespace Rsdo.Concordancer.Services.RequestHandlers.TermLists;

public class SearchTermListHandler : BaseSearchTermListHandler, IRequestHandler<SearchTermList, SearchTermListResponse>
{
    private readonly IQueryFactory<SearchTermList, TermListQuery> queryFactory;
    private readonly ISearchEngine searchEngine;

    public SearchTermListHandler(CorpusDbContext dbContext, IQueryFactory<SearchTermList, TermListQuery> queryFactory, ISearchEngine searchEngine)
        : base(dbContext)
    {
        this.queryFactory = queryFactory;
        this.searchEngine = searchEngine;
    }

    public async Task<SearchTermListResponse> Handle(SearchTermList request, CancellationToken cancellationToken)
    {
        // Convert request to search query
        var query = await queryFactory.GetQuery(request);

        // Execute search
        var result = await searchEngine.Search<Term, TermListQuery>(query);

        return new SearchTermListResponse()
        {
            Items = await GetItems(result.EntityIds),
            Offset = request.From,
            Total = result.Total,
        };
    }
}