using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Search.Queries.TermLists;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.Services.Services.InputQueryParser;
using Rsdo.Concordancer.Services.Services.LemmatizationService;

namespace Rsdo.Concordancer.Services.Search.QueryFactories.TermLists;

public class SearchTermListQueryFactory : BaseTermListQueryFactory, IQueryFactory<SearchTermList, TermListQuery>
{
    public SearchTermListQueryFactory(IInputQueryParser inputQueryParser, ILemmatizationService lemmatizationService)
        : base(inputQueryParser, lemmatizationService)
    {
    }

    public async Task<TermListQuery> GetQuery(SearchTermList request)
    {
        var query = await GetQuery<SearchTermList, SearchTermListResponse>(request);
        query.WithPageInfo(request);
        return query;
    }
}