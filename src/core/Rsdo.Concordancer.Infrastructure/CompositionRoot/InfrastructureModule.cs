using System.Reflection;
using Autofac;
using Microsoft.Extensions.Configuration;
using Rsdo.Concordancer.Core.Search;
using Rsdo.Concordancer.Core.Search.Aggregations;
using Rsdo.Concordancer.Infrastructure.Search;
using Rsdo.Concordancer.Infrastructure.Search.AddRecordsHandlers;
using Rsdo.Concordancer.Infrastructure.Search.Aggregations;
using Rsdo.Concordancer.Infrastructure.Search.Client;
using Rsdo.Concordancer.Infrastructure.Search.DeleteRecordsHandlers;
using Rsdo.Concordancer.Infrastructure.Search.Indexes;
using Rsdo.Concordancer.Infrastructure.Search.QueryBuilders;
using Rsdo.Concordancer.ServiceModel.Types;
using Module = Autofac.Module;

namespace Rsdo.Concordancer.Infrastructure.CompositionRoot;

public class InfrastructureModule : Module
{
    private Assembly InfrastructureAssembly => GetType().Assembly;

    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        RegisterConfiguration(builder);
        RegisterSearch(builder);
    }

    private static void RegisterConfiguration(ContainerBuilder builder)
    {
        var configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
        builder.RegisterInstance(configuration).As<IConfiguration>().SingleInstance();
    }

    private void RegisterSearch(ContainerBuilder builder)
    {
        // Search engine
        builder.RegisterType<ElasticSearchEngine>().As<ISearchEngine>().SingleInstance();

        // Elastic client
        builder.RegisterType<ElasticClientFactory>().As<IElasticClientFactory>().SingleInstance();
        builder.Register(
                c =>
                {
                    var factory = c.Resolve<IElasticClientFactory>();
                    return factory.Get();
                })
            .SingleInstance();

        // Index providers
        builder.RegisterType<IndexProviderFactory>().As<IIndexProviderFactory>().SingleInstance();
        builder.RegisterAssemblyTypes(InfrastructureAssembly).AsClosedTypesOf(typeof(IIndexProvider<>)).AsImplementedInterfaces().SingleInstance();

        // Add and delete records
        builder.RegisterType<AddRecordsHandlerFactory>().As<IAddRecordsHandlerFactory>().SingleInstance();
        builder.RegisterType<DeleteRecordsHandlerFactory>().As<IDeleteRecordsHandlerFactory>().SingleInstance();
        builder.RegisterAssemblyTypes(InfrastructureAssembly).AsClosedTypesOf(typeof(IAddRecordsHandler<>)).AsImplementedInterfaces().SingleInstance();
        builder.RegisterAssemblyTypes(InfrastructureAssembly).AsClosedTypesOf(typeof(IDeleteRecordsHandler<>)).AsImplementedInterfaces().SingleInstance();

        // Query builders
        builder.RegisterType<QueryBuilderFactory>().As<IQueryBuilderFactory>().SingleInstance();
        builder.RegisterAssemblyTypes(InfrastructureAssembly).AsClosedTypesOf(typeof(IQueryBuilder<>)).AsImplementedInterfaces().SingleInstance();

        // Aggregations
        builder.RegisterType<AggregatorFactory>().As<IAggregatorFactory>().SingleInstance();
        builder.RegisterType<TextAggregator>().Keyed<IAggregator>(AggregationType.Text).SingleInstance();
    }
}