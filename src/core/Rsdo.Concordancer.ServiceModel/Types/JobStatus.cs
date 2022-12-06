namespace Rsdo.Concordancer.ServiceModel.Types;

public enum JobStatus
{
    // Waiting
    Waiting = 0,

    // Processing
    Processing = 50,

    // Processed
    Processed = 100,

    // Failed
    Failed = 200,

    // Cancelled
    Cancelled = 201,
}