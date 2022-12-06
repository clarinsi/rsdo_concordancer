using System.Threading.Tasks;
using Rsdo.Concordancer.ServiceModel.Requests.Shared;
using Rsdo.Concordancer.ServiceModel.Types;

namespace Rsdo.Concordancer.Services.Search.AlternateSearches;

public interface IAlternateSearchProvider<TRequest, TResponse>
    where TRequest : Search<TResponse>
{
    Task<AlternateSearch<TRequest, TResponse>> Get(TRequest request);
}