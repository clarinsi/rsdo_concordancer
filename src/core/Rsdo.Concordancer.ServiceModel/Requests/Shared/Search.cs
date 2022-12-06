using System;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.ServiceModel.Requests.Shared;

public abstract class Search<TResponse> : IHaveCorpusId, IRequest<TResponse>
{
    public Guid CorpusId { get; set; }

    public string Query { get; set; }
}