using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.Core.Interfaces;

public interface IMediator
{
    Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default);

    [DisplayName("{0}")]
    Task<TResponse> Send<TResponse>(string requestName, IRequest<TResponse> request, CancellationToken cancellationToken = default);
}