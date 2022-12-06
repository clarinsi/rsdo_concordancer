using Autofac;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Data.Framework;
using Rsdo.Concordancer.Data.Services;

namespace Rsdo.Concordancer.Data.CompositionRoot;

public class DataModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder.RegisterType<ConnectionStringProvider>().As<IConnectionStringProvider>().SingleInstance();
        builder.RegisterType<DatabaseMigrationRunner>().As<IDatabaseMigrationRunner>().SingleInstance();
    }
}