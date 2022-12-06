using System;

namespace Rsdo.Concordancer.ServiceModel.Interfaces;

public interface IHaveCorpusId
{
    public Guid CorpusId { get; set; }
}