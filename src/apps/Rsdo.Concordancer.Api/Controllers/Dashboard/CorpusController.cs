using System;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Corpuses;
using Rsdo.Concordancer.ServiceModel.Shared;
using Swashbuckle.AspNetCore.Annotations;

namespace Rsdo.Concordancer.Api.Controllers.Dashboard;

public class CorpusController : BaseDashboardController
{
    public CorpusController(IMediator mediator)
        : base(mediator)
    {
    }

    [HttpGet("{corpusId:guid}")]
    [SwaggerOperation("Returns information about corpus")]
    [SwaggerResponse((int)HttpStatusCode.OK, "Information about corpus", typeof(GetCorpusResponse), MediaTypeNames.Application.Json)]
    [SwaggerResponse((int)HttpStatusCode.NotFound, "Corpus was not found")]
    [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Internal server error")]
    public async Task<GetCorpusResponse> Get([SwaggerParameter("Corpus id", Required = true)] Guid corpusId)
    {
        var request = new GetCorpus()
        {
            CorpusId = corpusId,
        };
        return await Mediator.Send(request);
    }

    [HttpPost]
    [SwaggerOperation("Creates new corpus")]
    [SwaggerResponse((int)HttpStatusCode.Created, "Corpus was created", typeof(ExecutionResult), MediaTypeNames.Application.Json)]
    [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Internal server error")]
    public async Task<ExecutionResult> Create([SwaggerParameter("Corpus information", Required = true)] CreateCorpus request)
    {
        Response.StatusCode = (int)HttpStatusCode.Created;
        return await Mediator.Send(request);
    }

    [HttpDelete("{corpusId:guid}")]
    [SwaggerOperation("Deletes corpus")]
    [SwaggerResponse((int)HttpStatusCode.OK, "Corpus was deleted", typeof(ExecutionResult), MediaTypeNames.Application.Json)]
    [SwaggerResponse((int)HttpStatusCode.NotFound, "Corpus was not found")]
    [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Internal server error")]
    public async Task<ExecutionResult> Delete([SwaggerParameter("Corpus id", Required = true)] Guid corpusId)
    {
        var request = new DeleteCorpus()
        {
            CorpusId = corpusId,
        };
        return await Mediator.Send(request);
    }
}