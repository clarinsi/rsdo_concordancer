using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Concordances;

namespace Rsdo.Concordancer.Api.Controllers.Concordancer;

public class ConcordancesController : BaseConcordancerController
{
    public ConcordancesController(IMediator mediator)
        : base(mediator)
    {
    }

    [HttpPost("concordances/details")]
    public async Task<ConcordanceDetailsResponse> Details(Guid corpusId, ConcordanceDetails request)
    {
        request.CorpusId = corpusId;
        return await Mediator.Send(request);
    }

    [HttpPost("concordances/search")]
    public async Task<SearchConcordancesResponse> Search(Guid corpusId, SearchConcordances request)
    {
        request.CorpusId = corpusId;
        return await Mediator.Send(request);
    }

    [HttpPost("concordances/export")]
    public async Task<IActionResult> Export(Guid corpusId, ExportConcordances request)
    {
        request.CorpusId = corpusId;
        var response = await Mediator.Send(request);
        return File(response.Stream, response.ContentType, response.FileName);
    }
}