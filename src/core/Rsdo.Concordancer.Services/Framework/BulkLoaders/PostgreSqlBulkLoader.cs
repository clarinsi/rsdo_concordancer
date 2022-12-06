using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Services.Framework.DbContext;

namespace Rsdo.Concordancer.Services.Framework.BulkLoaders;

public class PostgreSqlBulkLoader : IBulkLoader
{
    private readonly CorpusDbContext corpusDbContext;
    private readonly MasterDbContext masterDbContext;

    public PostgreSqlBulkLoader(CorpusDbContext corpusDbContext, MasterDbContext masterDbContext)
    {
        this.corpusDbContext = corpusDbContext;
        this.masterDbContext = masterDbContext;
    }

    public Task InsertEntities<TEntity>(List<TEntity> entities, CancellationToken cancellationToken)
        where TEntity : Entity
    {
        return InsertEntities(entities, true, cancellationToken);
    }

    public async Task InsertEntities<TEntity>(List<TEntity> entities, bool loadAutoIds, CancellationToken cancellationToken)
        where TEntity : Entity
    {
        // Get table and field names
        var entityType = GetEntityType<TEntity>();
        var tableName = entityType.GetTableName();
        var storeObjectIdentifier = GetTableIdentifier(entityType);
        var keyProperties = entityType.FindPrimaryKey().Properties;
        var dataProperties = entityType.GetDeclaredProperties()
            .Where(x => keyProperties.All(kp => kp.Name != x.Name) && x.GetColumnName(storeObjectIdentifier) != null)
            .ToList();
        var dataFieldNames = dataProperties.Select(p => p.GetColumnName(storeObjectIdentifier)).ToList();
        var copyFromCommand = $"COPY {tableName} ({string.Join(",", dataFieldNames)}) FROM STDIN (FORMAT BINARY)";

        var dbContext = GetDbContext<TEntity>();
        await using var connection = new NpgsqlConnection(dbContext.Database.GetConnectionString());

        // Load data into table
        await connection.OpenAsync(cancellationToken);
        await using (var writer = await connection.BeginBinaryImportAsync(copyFromCommand, cancellationToken))
        {
            foreach (var entity in entities)
            {
                await writer.StartRowAsync(cancellationToken);
                var values = dbContext.Entry(entity).CurrentValues;
                foreach (var dataProperty in dataProperties)
                {
                    var value = values[dataProperty];
                    if (value == null)
                    {
                        await writer.WriteNullAsync(cancellationToken);
                    }
                    else
                    {
                        if (dataProperty.ClrType.IsEnum)
                        {
                            // Try to cast enums to byte
                            value = Convert.ToByte(value);
                        }

                        await writer.WriteAsync(value, cancellationToken);
                    }
                }
            }

            await writer.CompleteAsync(cancellationToken);
        }

        if (loadAutoIds)
        {
            await GetEntityIdentifiers(entities, connection);
        }
    }

    private static StoreObjectIdentifier GetTableIdentifier(IReadOnlyEntityType entityType)
    {
        var tableName = entityType.GetTableName();
        var schema = entityType.GetSchema();
        return StoreObjectIdentifier.Table(tableName!, schema);
    }

    private async Task GetEntityIdentifiers<TEntity>(List<TEntity> entities, NpgsqlConnection connection)
        where TEntity : Entity
    {
        // Get table and field names
        var entityType = GetEntityType<TEntity>();
        var tableName = entityType.GetTableName();
        var storeObjectIdentifier = GetTableIdentifier(entityType);
        var autoIdFieldName = entityType.GetProperty(nameof(Entity.AutoId)).GetColumnName(storeObjectIdentifier);
        var entityIdFieldName = entityType.GetProperty(nameof(Entity.Id)).GetColumnName(storeObjectIdentifier);

        // Get all Id->AutoId mappings
        var autoIds = new Dictionary<Guid, long>();
        foreach (var chunk in entities.Chunk(1000))
        {
            var ids = string.Join(",", chunk.Select(e => "'" + e.Id + "'"));
            var sql = $"SELECT {autoIdFieldName}, {entityIdFieldName} FROM {tableName} WHERE {entityIdFieldName} IN ({ids})";
            await using var command = new NpgsqlCommand(sql, connection);
            await using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                autoIds.Add(reader.GetGuid(1), reader.GetInt64(0));
            }
        }

        // Update entity AutoIds
        foreach (var entity in entities)
        {
            entity.AutoId = autoIds[entity.Id];
        }
    }

    private Microsoft.EntityFrameworkCore.DbContext GetDbContext<TEntity>()
    {
        return corpusDbContext.Model.FindEntityType(typeof(TEntity)) != null ? corpusDbContext : masterDbContext;
    }

    private IEntityType GetEntityType<TEntity>()
    {
        var entityType = corpusDbContext.Model.FindEntityType(typeof(TEntity)) ?? masterDbContext.Model.FindEntityType(typeof(TEntity));

        if (entityType == null)
        {
            throw new Exception($"Entity type {typeof(TEntity).FullName} is not mapped in database context!");
        }

        return entityType;
    }
}