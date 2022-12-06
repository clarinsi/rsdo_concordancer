using System.Collections.Generic;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Search.Queries;

namespace Rsdo.Concordancer.Core.Search.Aggregations;

public interface IAggregator
{
    Task<IDictionary<string, long>> Get<TQuery>(TQuery query)
        where TQuery : Query;
}