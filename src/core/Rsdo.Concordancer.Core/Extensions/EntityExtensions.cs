using System;
using Rsdo.Concordancer.Core.Entities;

namespace Rsdo.Concordancer.Core.Extensions;

public static class EntityExtensions
{
    public static TEntity ApplyCreateValues<TEntity>(this TEntity entity)
        where TEntity : Entity
    {
        entity.Id = Guid.NewGuid();
        entity.CreatedDate = DateTime.Now;
        entity.ModifiedDate = entity.CreatedDate;
        return entity;
    }

    public static TEntity ApplyUpdateValues<TEntity>(this TEntity entity)
        where TEntity : Entity
    {
        entity.ModifiedDate = DateTime.Now;
        return entity;
    }
}