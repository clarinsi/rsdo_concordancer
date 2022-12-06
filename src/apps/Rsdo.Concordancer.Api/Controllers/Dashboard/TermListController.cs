using System;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;
using Rsdo.Concordancer.ServiceModel.Shared;
using Swashbuckle.AspNetCore.Annotations;

namespace Rsdo.Concordancer.Api.Controllers.Dashboard;

public class TermListController : BaseDashboardController
{
    public TermListController(IMediator mediator)
        : base(mediator)
    {
    }

    [HttpGet("{corpusId:guid}/termList/{termListId:guid}")]
    [SwaggerOperation("Returns information about term list")]
    [SwaggerResponse((int)HttpStatusCode.OK, "Information about term list", typeof(GetTermListResponse), MediaTypeNames.Application.Json)]
    [SwaggerResponse((int)HttpStatusCode.NotFound, "Term list was not found")]
    [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Internal server error")]
    public async Task<GetTermListResponse> Get(
        [SwaggerParameter("Corpus id", Required = true)] Guid corpusId,
        [SwaggerParameter("Term list id", Required = true)] Guid termListId)
    {
        var request = new GetTermList()
        {
            CorpusId = corpusId,
            TermListId = termListId,
        };
        return await Mediator.Send(request);
    }

    [HttpPost("{corpusId:guid}/termList")]
    [SwaggerOperation("Creates term list in selected corpus")]
    [SwaggerResponse((int)HttpStatusCode.Created, "Corpus was created", typeof(ExecutionResult), MediaTypeNames.Application.Json)]
    [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Internal server error")]
    public async Task<ExecutionResult> Create(
        [SwaggerParameter("Corpus id", Required = true)] Guid corpusId,
        [SwaggerParameter("Term list information", Required = true)] CreateTermList request)
    {
        Response.StatusCode = (int)HttpStatusCode.Created;
        request.CorpusId = corpusId;
        return await Mediator.Send(request);
    }

    [HttpDelete("{corpusId:guid}/termList/{termListId:guid}")]
    [SwaggerOperation("Deletes term list from selected corpus")]
    [SwaggerResponse((int)HttpStatusCode.OK, "Term list was deleted", typeof(ExecutionResult), MediaTypeNames.Application.Json)]
    [SwaggerResponse((int)HttpStatusCode.NotFound, "Term list was not found")]
    [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Internal server error")]
    public async Task<ExecutionResult> Delete(
        [SwaggerParameter("Corpus id", Required = true)] Guid corpusId,
        [SwaggerParameter("Term list id", Required = true)] Guid termListId)
    {
        var request = new DeleteTermList()
        {
            CorpusId = corpusId,
            TermListId = termListId,
        };
        return await Mediator.Send(request);
    }
}