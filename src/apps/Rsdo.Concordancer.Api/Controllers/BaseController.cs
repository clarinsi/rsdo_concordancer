using Microsoft.AspNetCore.Mvc;
using Rsdo.Concordancer.Core.Interfaces;

namespace Rsdo.Concordancer.Api.Controllers;

[ApiController]
public abstract class BaseController : ControllerBase
{
    protected BaseController(IMediator mediator)
    {
        Mediator = mediator;
    }

    protected IMediator Mediator { get; }
}