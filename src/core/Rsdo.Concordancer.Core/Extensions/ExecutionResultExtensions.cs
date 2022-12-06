using System;
using Rsdo.Concordancer.ServiceModel.Shared;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Core.Extensions;

public static class ExecutionResultExtensions
{
    public static ExecutionResult WithEntityInfo(this ExecutionResult instance, EntityType entityType, Guid entityId)
    {
        instance.EntityInfo = new EntityInfo()
        {
            EntityType = entityType,
            Id = entityId,
        };
        return instance;
    }
}