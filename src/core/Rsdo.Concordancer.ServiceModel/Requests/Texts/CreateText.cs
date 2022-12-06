using System;
using Rsdo.Concordancer.ServiceModel.Interfaces;
using Rsdo.Concordancer.ServiceModel.Shared;
using Swashbuckle.AspNetCore.Annotations;

namespace Rsdo.Concordancer.ServiceModel.Requests.Texts;

[SwaggerSchema(
    "Text information",
    Required = new[]
    {
        "corpusId",
        "sourceFile",
    })]
public class CreateText : IRequest<ExecutionResult>, IHaveCorpusId
{
    [SwaggerSchema("Author")]
    public string Author { get; set; }

    [SwaggerSchema("Corpus id")]
    public Guid CorpusId { get; set; }

    [SwaggerSchema("Absolute path to the conllu file containing tokenized and marked text")]
    public string SourceFile { get; set; }

    [SwaggerSchema("Title")]
    public string Title { get; set; }

    [SwaggerSchema("Year")]
    public short? Year { get; set; }
}