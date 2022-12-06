namespace Rsdo.Concordancer.Infrastructure.Search.DeleteRecordsHandlers;

public interface IDeleteRecordsHandlerFactory
{
    IDeleteRecordsHandler<TEntity> GetHandler<TEntity>();
}