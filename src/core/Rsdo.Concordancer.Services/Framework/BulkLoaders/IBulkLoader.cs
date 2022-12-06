using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Rsdo.Concordancer.Core.Entities;

namespace Rsdo.Concordancer.Services.Framework.BulkLoaders;

public interface IBulkLoader
{
    Task InsertEntities<TEntity>(List<TEntity> entities, CancellationToken cancellationToken)
        where TEntity : Entity;

    Task InsertEntities<TEntity>(List<TEntity> entities, bool loadAutoIds, CancellationToken cancellationToken)
        where TEntity : Entity;
}