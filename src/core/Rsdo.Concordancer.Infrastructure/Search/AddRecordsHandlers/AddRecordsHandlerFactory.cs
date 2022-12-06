using Autofac;

namespace Rsdo.Concordancer.Infrastructure.Search.AddRecordsHandlers;

public class AddRecordsHandlerFactory : IAddRecordsHandlerFactory
{
    private readonly ILifetimeScope lifetimeScope;

    public AddRecordsHandlerFactory(ILifetimeScope lifetimeScope)
    {
        this.lifetimeScope = lifetimeScope;
    }

    public IAddRecordsHandler<TEntity> GetHandler<TEntity>()
    {
        return lifetimeScope.Resolve<IAddRecordsHandler<TEntity>>();
    }
}