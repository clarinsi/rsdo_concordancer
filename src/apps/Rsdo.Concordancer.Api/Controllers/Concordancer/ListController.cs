using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.TermLists;

namespace Rsdo.Concordancer.Api.Controllers.Concordancer;

public class ListController : BaseConcordancerController
{
    public ListController(IMediator mediator)
        : base(mediator)
    {
    }

    [HttpPost("list/search")]
    public async Task<SearchTermListResponse> Search(Guid corpusId, SearchTermList request)
    {
        request.CorpusId = corpusId;
        return await Mediator.Send(request);
    }

    [HttpPost("list/export")]
    public async Task<IActionResult> Export(Guid corpusId, ExportTermList request)
    {
        request.CorpusId = corpusId;
        var response = await Mediator.Send(request);
        return File(response.Stream, response.ContentType, response.FileName);
    }
}