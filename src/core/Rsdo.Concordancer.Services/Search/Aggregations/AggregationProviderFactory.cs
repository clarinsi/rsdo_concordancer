using Autofac;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Services.Search.Aggregations;

public class AggregationProviderFactory : IAggregationProviderFactory
{
    private readonly ILifetimeScope lifetimeScope;

    public AggregationProviderFactory(ILifetimeScope lifetimeScope)
    {
        this.lifetimeScope = lifetimeScope;
    }

    public IAggregationProvider GetProvider(AggregationType aggregationType)
    {
        return lifetimeScope.ResolveKeyed<IAggregationProvider>(aggregationType);
    }
}