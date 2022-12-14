namespace Rsdo.Concordancer.Core.Constants;

public static class ConfigurationKey
{
    public static class Database
    {
        public const string MasterConnectionString = "RSDO:Database:MasterConnectionString";
    }

    public static class Search
    {
        public const string ElasticConnectionString = "RSDO:Elastic:ConnectionString";
    }

    public static class Tokenizer
    {
        public const string ClasslaTokenizerUrl = "RSDO:Tokenizer:ClasslaUrl";
    }
}