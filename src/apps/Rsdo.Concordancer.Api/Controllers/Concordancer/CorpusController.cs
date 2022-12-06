using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rsdo.Concordancer.Core.Interfaces;
using Rsdo.Concordancer.ServiceModel.Requests.Corpuses;

namespace Rsdo.Concordancer.Api.Controllers.Concordancer;

public class CorpusController : BaseConcordancerController
{
    public CorpusController(IMediator mediator)
        : base(mediator)
    {
    }

    [HttpGet("stats")]
    public async Task<GetCorpusStatisticsResponse> Statistics(Guid corpusId)
    {
        var request = new GetCorpusStatistics()
        {
            CorpusId = corpusId,
        };
        return await Mediator.Send(request);
    }
}