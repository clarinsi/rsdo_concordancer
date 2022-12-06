using System;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using FluentValidation;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.Services.Framework.Decorators;

public class RequestValidationDecorator<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IRequestHandler<TRequest, TResponse> decoratedHandler;
    private readonly ILifetimeScope lifetimeScope;

    public RequestValidationDecorator(IRequestHandler<TRequest, TResponse> decoratedHandler, ILifetimeScope lifetimeScope)
    {
        this.decoratedHandler = decoratedHandler;
        this.lifetimeScope = lifetimeScope;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
    {
        if (lifetimeScope.TryResolve<IValidator<TRequest>>(out var validator))
        {
            await validator.ValidateAndThrowAsync(request, cancellationToken);
        }

        return await decoratedHandler.Handle(request, cancellationToken);
    }
}