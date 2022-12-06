namespace Rsdo.Concordancer.Infrastructure.Search.AddRecordsHandlers;

public interface IAddRecordsHandlerFactory
{
    IAddRecordsHandler<TEntity> GetHandler<TEntity>();
}