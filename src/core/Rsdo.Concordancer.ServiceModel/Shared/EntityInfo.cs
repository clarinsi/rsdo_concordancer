using System;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.ServiceModel.Shared;

public class EntityInfo
{
    public EntityType EntityType { get; set; }

    public Guid Id { get; set; }
}