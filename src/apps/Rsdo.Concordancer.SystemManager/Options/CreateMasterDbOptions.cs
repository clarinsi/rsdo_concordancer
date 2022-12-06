using CommandLine;

namespace Rsdo.Concordancer.SystemManager.Options;

[Verb("createMasterDb", HelpText = "Creates master database.")]
public class CreateMasterDbOptions
{
    [Option("connectionString", Required = true, HelpText = "Connection string to database server.")]
    public string ConnectionString { get; set; }

    [Option("name", HelpText = "Master database name")]
    public string MasterDbName { get; set; } = "Concordancer";
}