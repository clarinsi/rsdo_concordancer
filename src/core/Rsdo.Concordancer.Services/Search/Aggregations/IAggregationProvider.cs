using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Search.Queries;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Services.Search.Aggregations;

public interface IAggregationProvider
{
    Task<Aggregation> Get<TQuery>(TQuery query)
        where TQuery : Query;
}