using System;
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace DesignStudioErp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public abstract class BaseController : ControllerBase
{
    private ILogger<BaseController>? _logger;
    protected ILogger<BaseController>? Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<BaseController>>();

    private IMapper _mapper;
    protected IMapper Mapper => _mapper ??= HttpContext.RequestServices.GetService<IMapper>();


    internal Guid UserId => !User.Identity.IsAuthenticated
        ? Guid.Empty
        : Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
}
