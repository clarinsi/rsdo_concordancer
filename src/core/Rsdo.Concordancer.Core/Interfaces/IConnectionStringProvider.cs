using System;

namespace Rsdo.Concordancer.Core.Interfaces;

public interface IConnectionStringProvider
{
    string GetCorpusConnectionString();

    string GetCorpusConnectionString(Guid corpusId);

    string GetCorpusDatabaseName();

    string GetMasterConnectionString();
}