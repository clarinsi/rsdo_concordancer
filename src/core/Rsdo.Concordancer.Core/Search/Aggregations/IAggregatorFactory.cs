using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Core.Search.Aggregations;

public interface IAggregatorFactory
{
    IAggregator GetAggregator(AggregationType aggregationType);
}