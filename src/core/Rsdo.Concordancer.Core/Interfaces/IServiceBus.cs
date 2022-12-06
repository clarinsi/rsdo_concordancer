using System.Threading.Tasks;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.Core.Interfaces;

public interface IServiceBus
{
    Task Send<TResponse>(IRequest<TResponse> request);
}