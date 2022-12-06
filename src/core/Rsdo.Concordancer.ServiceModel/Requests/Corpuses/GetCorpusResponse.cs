using System;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.ServiceModel.Requests.Corpuses;

public class GetCorpusResponse
{
    public string Description { get; set; }

    public Guid Id { get; set; }

    public CorpusStatus Status { get; set; }

    public string Title { get; set; }
}