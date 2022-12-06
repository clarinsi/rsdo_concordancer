using System.Collections.Generic;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Search.Aggregations;
using Rsdo.Concordancer.Core.Search.Queries;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Services.Search.Aggregations;

public abstract class BaseAggregationProvider : IAggregationProvider
{
    private readonly IAggregatorFactory aggregatorFactory;

    protected BaseAggregationProvider(IAggregatorFactory aggregatorFactory)
    {
        this.aggregatorFactory = aggregatorFactory;
    }

    public abstract AggregationType Type { get; }

    public async Task<Aggregation> Get<TQuery>(TQuery query)
        where TQuery : Query
    {
        // Run aggregator
        var aggregator = aggregatorFactory.GetAggregator(Type);
        var items = await aggregator.Get(query);

        return new Aggregation()
        {
            Items = await GetItems(items),
            Type = Type,
        };
    }

    protected abstract Task<List<AggregationItem>> GetItems(IDictionary<string, long> items);
}