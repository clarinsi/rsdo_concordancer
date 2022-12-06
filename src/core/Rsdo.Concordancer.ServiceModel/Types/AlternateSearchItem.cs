using Rsdo.Concordancer.ServiceModel.Requests.Shared;

namespace Rsdo.Concordancer.ServiceModel.Types;

public class AlternateSearchItem<TRequest, TResponse>
    where TRequest : Search<TResponse>
{
    public long Count { get; set; }

    public TRequest Search { get; set; }

    public string Title { get; set; }
}