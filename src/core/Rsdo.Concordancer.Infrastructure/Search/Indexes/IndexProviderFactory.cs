using System.Collections.Generic;
using Autofac;

namespace Rsdo.Concordancer.Infrastructure.Search.Indexes;

public class IndexProviderFactory : IIndexProviderFactory
{
    private readonly ILifetimeScope lifetimeScope;

    public IndexProviderFactory(ILifetimeScope lifetimeScope)
    {
        this.lifetimeScope = lifetimeScope;
    }

    public IEnumerable<IIndexProvider> GetAllProviders()
    {
        return lifetimeScope.Resolve<IEnumerable<IIndexProvider>>();
    }

    public IIndexProvider<TModel> GetProvider<TModel>()
    {
        return lifetimeScope.Resolve<IIndexProvider<TModel>>();
    }
}