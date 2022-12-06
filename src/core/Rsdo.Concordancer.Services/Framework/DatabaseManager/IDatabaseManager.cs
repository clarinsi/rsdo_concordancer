using System;
using System.Threading.Tasks;

namespace Rsdo.Concordancer.Services.Framework.DatabaseManager;

public interface IDatabaseManager
{
    Task CreateCorpusDatabase();

    Task CreateMasterDatabase(string connectionString, string databaseName);

    Task DeleteCorpusDatabase();

    Task UpdateCorpusDatabases();

    Task UpdateMasterDatabase();
}