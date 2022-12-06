using System;
using Rsdo.Concordancer.ServiceModel.Interfaces;
using Rsdo.Concordancer.ServiceModel.Shared;

namespace Rsdo.Concordancer.ServiceModel.Requests.Corpuses;

public class DeleteCorpus : IRequest<ExecutionResult>, IHaveCorpusId
{
    public Guid CorpusId { get; set; }
}