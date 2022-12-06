using Microsoft.AspNetCore.Mvc;
using Rsdo.Concordancer.Core.Interfaces;

namespace Rsdo.Concordancer.Api.Controllers.Concordancer;

[ApiExplorerSettings(GroupName = ServiceApiInfo.ApiGroupConcordancer)]
[Route(ServiceApiInfo.ApiGroupConcordancer + "/corpus/{corpusId:guid}")]
public abstract class BaseConcordancerController : BaseController
{
    protected BaseConcordancerController(IMediator mediator)
        : base(mediator)
    {
    }
}