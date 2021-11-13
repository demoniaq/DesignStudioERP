using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DesignStudioErp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public abstract class BaseController : ControllerBase
{
    private ILogger<BaseController>? _logger;
    protected ILogger<BaseController>? Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<BaseController>>();

    internal Guid UserId => !User.Identity.IsAuthenticated
        ? Guid.Empty
        : Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
}
