namespace Rsdo.Concordancer.ServiceModel.Types;

public enum CorpusStatus : byte
{
    // Corpus is offline (inactive)
    Offline = 0,

    // Corpus is under maintenance (reindexing)
    Maintenance = 25,

    // Corpus is being created (database and indexes are not yet created)
    Creating = 50,

    // Corpus is active and can be used
    Active = 100,

    // Error occured when corpus was created
    Faulted = 200,

    // Corpus is marked as deleted (will be deleted by the worker)
    Deleted = 201,
}