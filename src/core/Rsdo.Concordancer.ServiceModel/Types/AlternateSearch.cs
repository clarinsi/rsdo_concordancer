using System.Collections.Generic;
using Rsdo.Concordancer.ServiceModel.Requests.Shared;

namespace Rsdo.Concordancer.ServiceModel.Types;

public class AlternateSearch<TRequest, TResponse>
    where TRequest : Search<TResponse>
{
    public List<AlternateSearchItem<TRequest, TResponse>> Items { get; set; }

    public TRequest OriginalSearch { get; set; }

    public AlternateSearchType Type { get; set; }
}