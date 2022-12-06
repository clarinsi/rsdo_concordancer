using System;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.ServiceModel.Requests.Corpuses;

public class GetCorpus : IHaveCorpusId, IRequest<GetCorpusResponse>
{
    public Guid CorpusId { get; set; }
}