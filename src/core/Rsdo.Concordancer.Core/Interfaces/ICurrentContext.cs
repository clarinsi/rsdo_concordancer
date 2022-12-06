using System;

namespace Rsdo.Concordancer.Core.Interfaces;

public interface ICurrentContext
{
    Guid CorpusId { get; set; }
}