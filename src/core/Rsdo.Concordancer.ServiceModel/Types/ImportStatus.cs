namespace Rsdo.Concordancer.ServiceModel.Types;

public enum ImportStatus : byte
{
    // Data is waiting to be imported
    Waiting = 50,

    // Data is being importing
    Importing = 60,

    // Data is imported
    ImportingCompleted = 70,

    // Data is being indexing
    Indexing = 80,

    // Data is indexed
    IndexingCompleted = 90,

    // Data is active and can be used
    Active = 100,

    // Error occured during importing of data
    ImportingFaulted = 200,

    // Error occured during indexing of data
    IndexingFaulted = 210,

    // Data  is marked as deleted (will be deleted by the worker)
    Deleted = 220,
}