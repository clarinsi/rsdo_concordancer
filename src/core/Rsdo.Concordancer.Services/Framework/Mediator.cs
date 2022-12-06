using System;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.Services.Framework;

public class Mediator : IMediator
{
    private readonly ILifetimeScope lifetimeScope;

    public Mediator(ILifetimeScope lifetimeScope)
    {
        this.lifetimeScope = lifetimeScope;
    }

    public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
    {
        return SendInternal(request, cancellationToken);
    }

    public Task<TResponse> Send<TResponse>(string requestName, IRequest<TResponse> request, CancellationToken cancellationToken = default)
    {
        return SendInternal(request, cancellationToken);
    }

    private Task<TResponse> SendInternal<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
    {
        var handlerType = typeof(IRequestHandler<,>).MakeGenericType(request.GetType(), typeof(TResponse));
        var handler = (dynamic)lifetimeScope.Resolve(handlerType);
        return handler.Handle((dynamic)request, cancellationToken);
    }
}