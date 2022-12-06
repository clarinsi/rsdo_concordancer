using System;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Generators.Postgres;
using FluentMigrator.Runner.Initialization;
using FluentMigrator.Runner.VersionTableInfo;
using Microsoft.Extensions.DependencyInjection;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.Data.CompositionRoot;
using Rsdo.Concordancer.Data.Framework;

namespace Rsdo.Concordancer.Data.Services;

public class DatabaseMigrationRunner : IDatabaseMigrationRunner
{
    public void MigrateUp(string connectionString, MigrationTag migrationTag)
    {
        var serviceProvider = CreateServices(connectionString, migrationTag);

        using var scope = serviceProvider.CreateScope();
        UpdateDatabase(scope.ServiceProvider);
    }

    private static IServiceProvider CreateServices(string connectionString, MigrationTag migrationTag)
    {
        return new ServiceCollection().AddFluentMigratorCore()
            .ConfigureRunner(rb => rb.AddPostgres11_0().WithGlobalConnectionString(connectionString).ScanIn(typeof(DataModule).Assembly).For.Migrations())
            .AddLogging(lb => lb.AddFluentMigratorConsole())
            .Configure<RunnerOptions>(
                opt => opt.Tags = new[]
                {
                    migrationTag.ToString(),
                })
            .AddScoped<PostgresQuoter, NoQuoteQuoter>()
            .AddScoped<IVersionTableMetaData, VersionInfoTableMetadata>()
            .BuildServiceProvider(false);
    }

    private static void UpdateDatabase(IServiceProvider serviceProvider)
    {
        var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
        runner.MigrateUp();
    }
}