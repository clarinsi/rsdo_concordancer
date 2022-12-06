using Rsdo.Concordancer.ServiceModel.Interfaces;
using Rsdo.Concordancer.ServiceModel.Shared;

namespace Rsdo.Concordancer.ServiceModel.Requests.Sloleks;

public class ImportSloleks : IRequest<ExecutionResult>
{
    public string SourceFile { get; set; }
}