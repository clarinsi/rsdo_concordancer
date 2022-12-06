using System;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Texts;
using Rsdo.Concordancer.ServiceModel.Shared;
using Swashbuckle.AspNetCore.Annotations;

namespace Rsdo.Concordancer.Api.Controllers.Dashboard;

public class TextController : BaseDashboardController
{
    public TextController(IMediator mediator)
        : base(mediator)
    {
    }

    [HttpGet("{corpusId:guid}/text/{textId:guid}")]
    [SwaggerOperation("Returns information about text")]
    [SwaggerResponse((int)HttpStatusCode.OK, "Information about text", typeof(GetTextResponse), MediaTypeNames.Application.Json)]
    [SwaggerResponse((int)HttpStatusCode.NotFound, "Text was not found")]
    [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Internal server error")]
    public async Task<GetTextResponse> Get(
        [SwaggerParameter("Corpus id", Required = true)] Guid corpusId,
        [SwaggerParameter("Text id", Required = true)] Guid textId)
    {
        var request = new GetText()
        {
            CorpusId = corpusId,
            TextId = textId,
        };
        return await Mediator.Send(request);
    }

    [HttpPost("{corpusId:guid}/text")]
    [SwaggerOperation("Creates text in selected corpus")]
    [SwaggerResponse((int)HttpStatusCode.Created, "Text was created", typeof(ExecutionResult), MediaTypeNames.Application.Json)]
    [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Internal server error")]
    public async Task<ExecutionResult> Create(
        [SwaggerParameter("Corpus id", Required = true)] Guid corpusId,
        [SwaggerParameter("Text information", Required = true)] CreateText request)
    {
        Response.StatusCode = (int)HttpStatusCode.Created;
        request.CorpusId = corpusId;
        return await Mediator.Send(request);
    }

    [HttpDelete("{corpusId:guid}/text/{textId:guid}")]
    [SwaggerOperation("Deletes text from selected corpus")]
    [SwaggerResponse((int)HttpStatusCode.OK, "Text was deleted", typeof(ExecutionResult), MediaTypeNames.Application.Json)]
    [SwaggerResponse((int)HttpStatusCode.NotFound, "Text was not found")]
    [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Internal server error")]
    public async Task<ExecutionResult> Delete(
        [SwaggerParameter("Corpus id", Required = true)] Guid corpusId,
        [SwaggerParameter("Text id", Required = true)] Guid textId)
    {
        var request = new DeleteText()
        {
            CorpusId = corpusId,
            TextId = textId,
        };
        return await Mediator.Send(request);
    }
}