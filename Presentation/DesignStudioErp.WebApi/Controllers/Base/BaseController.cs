using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace DesignStudioErp.WebApi.Controllers.Base;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public abstract class BaseController : ControllerBase
{
    private ILogger<BaseController>? _logger;
    protected ILogger<BaseController> Logger
    {
        get
        {
            _logger ??= HttpContext.RequestServices.GetService<ILogger<BaseController>>();
            if (_logger == null)
            {
                throw new NullReferenceException(nameof(Logger));
            }
            return _logger;
        }
    }

    private IMapper? _mapper;
    protected IMapper Mapper
    {
        get
        {
            _mapper ??= HttpContext.RequestServices.GetService<IMapper>();
            if (_mapper == null)
            {
                throw new NullReferenceException(nameof(Mapper));
            }
            return _mapper;
        }
    }

    internal Guid UserId
    {
        get
        {
            bool isAuthenticated = User.Identity is not null && User.Identity.IsAuthenticated;
            return isAuthenticated
                   ? Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier))
                   : Guid.Empty;
        }
    }
}
