using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Search.Queries.Concordances;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Services.LemmatizationService;

namespace Rsdo.Concordancer.Services.Search.QueryFactories.Concordances;

public class ExportConcordancesQueryFactory : BaseConcordancesQueryFactory, IQueryFactory<ExportConcordances, ConcordancesQuery>
{
    public ExportConcordancesQueryFactory(ILemmatizationService lemmatizationService)
        : base(lemmatizationService)
    {
    }

    public async Task<ConcordancesQuery> GetQuery(ExportConcordances request)
    {
        var query = await GetQuery<ExportConcordances, ExportConcordancesResponse>(request);
        query.From = 0;
        query.ReturnRandomRows = request.Type == ConcordanceExportType.RandomRows;
        query.Size = request.Rows;
        return query;
    }
}