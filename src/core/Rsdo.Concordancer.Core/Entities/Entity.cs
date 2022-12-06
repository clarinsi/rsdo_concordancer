using System;

namespace Rsdo.Concordancer.Core.Entities;

public abstract class Entity
{
    public long AutoId { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid Id { get; set; }

    public DateTime ModifiedDate { get; set; }
}