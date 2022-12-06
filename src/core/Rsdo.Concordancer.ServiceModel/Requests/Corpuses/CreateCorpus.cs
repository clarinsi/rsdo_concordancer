using Rsdo.Concordancer.ServiceModel.Interfaces;
using Rsdo.Concordancer.ServiceModel.Shared;
using Swashbuckle.AspNetCore.Annotations;

namespace Rsdo.Concordancer.ServiceModel.Requests.Corpuses;

[SwaggerSchema(
    "Corpus information",
    Required = new[]
    {
        "title",
    })]
public class CreateCorpus : IRequest<ExecutionResult>
{
    [SwaggerSchema("Description")]
    public string Description { get; set; }

    [SwaggerSchema("Title")]
    public string Title { get; set; }
}