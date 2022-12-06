using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Search.Queries.TermLists;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.Services.Services.InputQueryParser;
using Rsdo.Concordancer.Services.Services.LemmatizationService;

namespace Rsdo.Concordancer.Services.Search.QueryFactories.TermLists;

public class ExportTermListQueryFactory : BaseTermListQueryFactory, IQueryFactory<ExportTermList, TermListQuery>
{
    public ExportTermListQueryFactory(IInputQueryParser inputQueryParser, ILemmatizationService lemmatizationService)
        : base(inputQueryParser, lemmatizationService)
    {
    }

    public async Task<TermListQuery> GetQuery(ExportTermList request)
    {
        var query = await GetQuery<ExportTermList, ExportTermListResponse>(request);
        query.From = 0;
        query.Size = request.Rows;
        return query;
    }
}