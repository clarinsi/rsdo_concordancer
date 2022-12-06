using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.Services.Framework.Decorators;

public class LoggingDecorator<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IRequestHandler<TRequest, TResponse> decoratedHandler;
    private readonly ILogger<TRequest> logger;

    public LoggingDecorator(IRequestHandler<TRequest, TResponse> decoratedHandler, ILogger<TRequest> logger)
    {
        this.decoratedHandler = decoratedHandler;
        this.logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Calling handler {handler} to handle {@request}.", decoratedHandler.GetType().ToString(), request);

        return await decoratedHandler.Handle(request, cancellationToken);
    }
}