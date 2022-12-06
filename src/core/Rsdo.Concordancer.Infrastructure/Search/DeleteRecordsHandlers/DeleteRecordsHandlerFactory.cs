using Autofac;

namespace Rsdo.Concordancer.Infrastructure.Search.DeleteRecordsHandlers;

public class DeleteRecordsHandlerFactory : IDeleteRecordsHandlerFactory
{
    private readonly ILifetimeScope lifetimeScope;

    public DeleteRecordsHandlerFactory(ILifetimeScope lifetimeScope)
    {
        this.lifetimeScope = lifetimeScope;
    }

    public IDeleteRecordsHandler<TEntity> GetHandler<TEntity>()
    {
        return lifetimeScope.Resolve<IDeleteRecordsHandler<TEntity>>();
    }
}