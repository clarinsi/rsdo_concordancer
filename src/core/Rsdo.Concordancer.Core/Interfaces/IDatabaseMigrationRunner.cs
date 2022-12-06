namespace Rsdo.Concordancer.Core.Interfaces;

public enum MigrationTag
{
    Master,
    Corpus,
}

public interface IDatabaseMigrationRunner
{
    void MigrateUp(string connectionString, MigrationTag migrationTag);
}