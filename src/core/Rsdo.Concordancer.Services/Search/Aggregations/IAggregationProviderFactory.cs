using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Services.Search.Aggregations;

public interface IAggregationProviderFactory
{
    IAggregationProvider GetProvider(AggregationType aggregationType);
}