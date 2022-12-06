using Autofac.Features.Indexed;
using Rsdo.Concordancer.Core.Search.Aggregations;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Infrastructure.Search.Aggregations;

public class AggregatorFactory : IAggregatorFactory
{
    private readonly IIndex<AggregationType, IAggregator> aggregators;

    public AggregatorFactory(IIndex<AggregationType, IAggregator> aggregators)
    {
        this.aggregators = aggregators;
    }

    public IAggregator GetAggregator(AggregationType aggregationType)
    {
        return aggregators[aggregationType];
    }
}