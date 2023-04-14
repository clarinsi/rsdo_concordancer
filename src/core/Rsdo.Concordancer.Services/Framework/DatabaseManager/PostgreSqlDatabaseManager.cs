using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Types;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.Framework.DatabaseManager;

public class PostgreSqlDatabaseManager : IDatabaseManager
{
    private readonly IConnectionStringProvider connectionStringProvider;
    private readonly IDatabaseMigrationRunner databaseMigrationRunner;
    private readonly MasterDbContext dbContext;

    public PostgreSqlDatabaseManager(
        IConnectionStringProvider connectionStringProvider,
        IDatabaseMigrationRunner databaseMigrationRunner,
        MasterDbContext dbContext)
    {
        this.connectionStringProvider = connectionStringProvider;
        this.databaseMigrationRunner = databaseMigrationRunner;
        this.dbContext = dbContext;
    }

    public async Task CreateCorpusDatabase()
    {
        // Create database
        var connectionString = connectionStringProvider.GetMasterConnectionString();
        var databaseName = connectionStringProvider.GetCorpusDatabaseName();
        await CreateDatabase(connectionString, databaseName);

        // Run migrations
        connectionString = connectionStringProvider.GetCorpusConnectionString();
        databaseMigrationRunner.MigrateUp(connectionString, MigrationTag.Corpus);
    }

    public async Task CreateMasterDatabase(string connectionString, string databaseName)
    {
        // Create database
        await CreateDatabase(connectionString, databaseName);

        // Run migrations
        var connectionStringWithDatabase = GetConnectionStringWithDatabase(connectionString, databaseName);
        databaseMigrationRunner.MigrateUp(connectionStringWithDatabase, MigrationTag.Master);
    }

    public async Task DeleteCorpusDatabase()
    {
        // Delete database
        var connectionString = connectionStringProvider.GetMasterConnectionString();
        var databaseName = connectionStringProvider.GetCorpusDatabaseName();
        await DeleteDatabase(connectionString, databaseName);
    }

    public async Task UpdateCorpusDatabases()
    {
        // Update all corpus databases
        var corpusIds = await dbContext.Corpus.Where(s => s.Status == CorpusStatus.Active).Select(c => c.Id).ToListAsync();
        foreach (var corpusId in corpusIds)
        {
            var connectionString = connectionStringProvider.GetCorpusConnectionString(corpusId);
            databaseMigrationRunner.MigrateUp(connectionString, MigrationTag.Corpus);
        }
    }

    public Task UpdateMasterDatabase()
    {
        // Update master database
        var connectionString = connectionStringProvider.GetMasterConnectionString();
        databaseMigrationRunner.MigrateUp(connectionString, MigrationTag.Master);
        return Task.CompletedTask;
    }

    private static async Task CreateDatabase(string connectionString, string databaseName)
    {
        // Open connection
        await using var connection = new NpgsqlConnection(connectionString);
        await connection.OpenAsync();

        // Check if database already exists
        var databaseExists = await DatabaseExists(connection, databaseName);
        if (databaseExists)
        {
            throw new Exception($"Database {databaseName} already exists!");
        }

        // Create database
        var sql = $"CREATE DATABASE \"{databaseName}\" ENCODING = 'UTF8'";
        await using var command = new NpgsqlCommand(sql, connection);
        await command.ExecuteNonQueryAsync();
    }

    private static async Task<bool> DatabaseExists(NpgsqlConnection connection, string databaseName)
    {
        var sql = $"SELECT datname FROM pg_catalog.pg_database WHERE datname = @databaseName";
        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("databaseName", databaseName);
        await using var reader = await command.ExecuteReaderAsync();
        return reader.HasRows;
    }

    private static async Task DeleteDatabase(string connectionString, string databaseName)
    {
        // Open connection
        await using var connection = new NpgsqlConnection(connectionString);
        await connection.OpenAsync();

        // Drop database
        var sql = $"DROP DATABASE IF EXISTS \"{databaseName}\" WITH (FORCE)";
        await using var command = new NpgsqlCommand(sql, connection);
        await command.ExecuteNonQueryAsync();
    }

    private static string GetConnectionStringWithDatabase(string connectionString, string databaseName)
    {
        var builder = new NpgsqlConnectionStringBuilder(connectionString)
        {
            Database = databaseName,
        };
        return builder.ToString();
    }
}