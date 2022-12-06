using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rsdo.Concordancer.Infrastructure.Search.DeleteRecordsHandlers;

public interface IDeleteRecordsHandler<TEntity>
{
    Task Delete(IEnumerable<Guid> entityIds);
}