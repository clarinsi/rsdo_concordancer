using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Extensions;
using Rsdo.Concordancer.Core.Search.Queries.Concordances;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;
using Rsdo.Concordancer.Services.Services.LemmatizationService;

namespace Rsdo.Concordancer.Services.Search.QueryFactories.Concordances;

public class SearchConcordancesQueryFactory : BaseConcordancesQueryFactory, IQueryFactory<SearchConcordances, ConcordancesQuery>
{
    public SearchConcordancesQueryFactory(ILemmatizationService lemmatizationService)
        : base(lemmatizationService)
    {
    }

    public async Task<ConcordancesQuery> GetQuery(SearchConcordances request)
    {
        var query = await GetQuery<SearchConcordances, SearchConcordancesResponse>(request);
        query.WithPageInfo(request);
        return query;
    }
}