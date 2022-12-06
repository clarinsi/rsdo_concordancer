using Microsoft.AspNetCore.Mvc;
using Rsdo.Concordancer.Core.Interfaces;

namespace Rsdo.Concordancer.Api.Controllers.Dashboard;

[ApiExplorerSettings(GroupName = ServiceApiInfo.ApiGroupDashboard)]
[Route(ServiceApiInfo.ApiGroupDashboard + "/corpus")]
public abstract class BaseDashboardController : BaseController
{
    protected BaseDashboardController(IMediator mediator)
        : base(mediator)
    {
    }
}