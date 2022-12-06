using Rsdo.Concordancer.Core.Search.Queries;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.Core.Extensions;

public static class QueryExtensions
{
    public static Query WithPageInfo(this Query query, IPagedSearch request)
    {
        query.From = request.From;
        query.Size = request.Size;
        return query;
    }
}