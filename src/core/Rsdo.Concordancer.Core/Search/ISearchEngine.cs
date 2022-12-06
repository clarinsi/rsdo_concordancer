using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Search.Queries;

namespace Rsdo.Concordancer.Core.Search;

public interface ISearchEngine
{
    Task Add<TEntity>(IEnumerable<TEntity> entities);

    Task Commit();

    Task CreateSchema();

    Task Delete<TEntity>(IEnumerable<Guid> entityIds);

    Task DeleteSchema();

    Task<QueryResult> Search<TEntity, TQuery>(TQuery query)
        where TEntity : class
        where TQuery : Query;
}