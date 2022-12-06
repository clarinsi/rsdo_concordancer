using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rsdo.Concordancer.Infrastructure.Search.AddRecordsHandlers;

public interface IAddRecordsHandler<TEntity>
{
    Task Add(IEnumerable<TEntity> entities);
}