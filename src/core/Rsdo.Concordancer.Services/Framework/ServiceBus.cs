using System;
using System.Threading;
using System.Threading.Tasks;
using Hangfire;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Interfaces;

namespace Rsdo.Concordancer.Services.Framework;

public class ServiceBus : IServiceBus
{
    public Task Send<TResponse>(IRequest<TResponse> request)
    {
        var requestName = request.GetType().Name;
        BackgroundJob.Enqueue<IMediator>(mediator => mediator.Send(requestName, request, CancellationToken.None));
        return Task.CompletedTask;
    }
}