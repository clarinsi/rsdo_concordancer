using System;
using Rsdo.Concordancer.ServiceModel.Interfaces;
using Rsdo.Concordancer.ServiceModel.Shared;
using Swashbuckle.AspNetCore.Annotations;

namespace Rsdo.Concordancer.ServiceModel.Requests.TermLists;

[SwaggerSchema(
    "Term list information",
    Required = new[]
    {
        "corpusId",
        "sourceFile",
    })]
public class CreateTermList : IRequest<ExecutionResult>, IHaveCorpusId
{
    [SwaggerSchema("Corpus id")]
    public Guid CorpusId { get; set; }

    [SwaggerSchema("Absolute path to the json file containing term list")]
    public string SourceFile { get; set; }
}