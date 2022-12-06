using System;
using Rsdo.Concordancer.Core.Interfaces;

namespace Rsdo.Concordancer.Core.Framework.CurrentContexts;

public abstract class CurrentContextBase : ICurrentContext
{
    public Guid CorpusId { get; set; }
}