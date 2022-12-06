using Autofac;
using Microsoft.Extensions.Logging;
using Rsdo.Concordancer.Data.CompositionRoot;
using Rsdo.Concordancer.Infrastructure.CompositionRoot;
using Rsdo.Concordancer.Services.CompositionRoot;

namespace Rsdo.Concordancer.SystemManager.CompositionRoot;

public class Bootstrapper
{
    public IContainer Bootstrap()
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule(new ServicesModule());
        builder.RegisterModule(new InfrastructureModule());
        builder.RegisterModule(new DataModule());

        // Logging
        builder.RegisterInstance(new LoggerFactory()).As<ILoggerFactory>();
        builder.RegisterGeneric(typeof(Logger<>)).As(typeof(ILogger<>)).SingleInstance();

        return builder.Build();
    }
}