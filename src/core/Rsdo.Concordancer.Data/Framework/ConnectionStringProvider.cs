using System;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Rsdo.Concordancer.Core.Constants;
using Rsdo.Concordancer.Core.Framework;
using Rsdo.Concordancer.Core.Interfaces;

namespace Rsdo.Concordancer.Data.Framework;

public class ConnectionStringProvider : IConnectionStringProvider
{
    private readonly IConfiguration configuration;

    public ConnectionStringProvider(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public string GetCorpusConnectionString()
    {
        return GetCorpusConnectionString(CurrentContext.Current.CorpusId);
    }

    public string GetCorpusConnectionString(Guid corpusId)
    {
        var masterConnectionString = GetMasterConnectionString();
        var masterBuilder = new NpgsqlConnectionStringBuilder(masterConnectionString)
        {
            Database = GetCorpusDatabaseName(corpusId),
        };
        return masterBuilder.ConnectionString;
    }

    public string GetCorpusDatabaseName()
    {
        return GetCorpusDatabaseName(CurrentContext.Current.CorpusId);
    }

    public string GetMasterConnectionString()
    {
        return configuration[ConfigurationKey.Database.MasterConnectionString];
    }

    private string GetMasterDatabaseName()
    {
        var connectionString = GetMasterConnectionString();
        return new NpgsqlConnectionStringBuilder(connectionString).Database;
    }

    private string GetCorpusDatabaseName(Guid corpusId)
    {
        var masterDatabaseName = GetMasterDatabaseName();
        return $"{masterDatabaseName}_{corpusId:N}";
    }
}