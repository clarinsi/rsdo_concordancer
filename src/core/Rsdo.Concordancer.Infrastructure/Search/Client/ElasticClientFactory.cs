using System;
using Microsoft.Extensions.Configuration;
using OpenSearch.Client;
using Rsdo.Concordancer.Core.Constants;

namespace Rsdo.Concordancer.Infrastructure.Search.Client;

public class ElasticClientFactory : IElasticClientFactory
{
    private readonly IConfiguration configuration;

    public ElasticClientFactory(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public IOpenSearchClient Get()
    {
        var connectionString = configuration[ConfigurationKey.Search.ElasticConnectionString];
        var connectionSettings = new ConnectionSettings(new Uri(connectionString)).SniffOnStartup(false).RequestTimeout(TimeSpan.FromSeconds(30));
#if DEBUG
        connectionSettings.EnableDebugMode().IncludeServerStackTraceOnError(false);
#endif
        return new OpenSearchClient(connectionSettings);
    }
}