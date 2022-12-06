using CommandLine;

namespace Rsdo.Concordancer.SystemManager.Options;

[Verb("importSloleks", HelpText = "Imports Sloleks into master database.")]
public class ImportSloleksOptions
{
    [Option("sourceFile", Required = true, HelpText = "Path to xml file.")]
    public string SourceFile { get; set; }
}