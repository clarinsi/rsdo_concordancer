using System;
using System.Threading.Tasks;
using Autofac;
using CommandLine;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Sloleks;
using Rsdo.Concordancer.Services.Framework.DatabaseManager;
using Rsdo.Concordancer.SystemManager.CompositionRoot;
using Rsdo.Concordancer.SystemManager.Options;

namespace Rsdo.Concordancer.SystemManager;

public class Program
{
    private static IContainer container;
    private static IMediator mediator;

    public static async Task Main(string[] args)
    {
        // Initialize container
        container = new Bootstrapper().Bootstrap();
        mediator = container.Resolve<IMediator>();

        // Parse arguments
        await Parser.Default.ParseArguments<CreateMasterDbOptions, ImportSloleksOptions, UpdateMasterDbOptions, UpdateCorpusDbOptions>(args)
            .MapResult(
                (CreateMasterDbOptions opt) => CreateMasterDb(opt),
                (ImportSloleksOptions opt) => ImportSloleks(opt),
                (UpdateMasterDbOptions _) => UpdateMasterDb(),
                (UpdateCorpusDbOptions _) => UpdateCorpusDb(),
                errors => Task.FromResult(-1));

        // Finished
        Console.WriteLine("Finished. Press any key to continue...");
        Console.ReadKey();
    }

    private static async Task<int> CreateMasterDb(CreateMasterDbOptions options)
    {
        var databaseManager = container.Resolve<IDatabaseManager>();
        await databaseManager.CreateMasterDatabase(options.ConnectionString, options.MasterDbName);
        return 0;
    }

    private static async Task<int> ImportSloleks(ImportSloleksOptions options)
    {
        var result = await mediator.Send(
            new ImportSloleks()
            {
                SourceFile = options.SourceFile,
            });
        return 0;
    }

    private static async Task<int> UpdateMasterDb()
    {
        var databaseManager = container.Resolve<IDatabaseManager>();
        await databaseManager.UpdateMasterDatabase();
        return 0;
    }

    private static async Task<int> UpdateCorpusDb()
    {
        var databaseManager = container.Resolve<IDatabaseManager>();
        await databaseManager.UpdateCorpusDatabases();
        return 0;
    }
}