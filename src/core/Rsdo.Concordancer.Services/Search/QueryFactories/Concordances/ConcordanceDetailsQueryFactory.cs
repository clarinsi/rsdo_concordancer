using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Search.Queries.Concordances;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;
using Rsdo.Concordancer.Services.Services.LemmatizationService;

namespace Rsdo.Concordancer.Services.Search.QueryFactories.Concordances;

public class ConcordanceDetailsQueryFactory : BaseConcordancesQueryFactory, IQueryFactory<ConcordanceDetails, ConcordancesQuery>
{
    public ConcordanceDetailsQueryFactory(ILemmatizationService lemmatizationService)
        : base(lemmatizationService)
    {
    }

    public async Task<ConcordancesQuery> GetQuery(ConcordanceDetails request)
    {
        var query = await GetQuery<ConcordanceDetails, ConcordanceDetailsResponse>(request);
        query.From = 0;
        query.Size = 0;
        return query;
    }
}