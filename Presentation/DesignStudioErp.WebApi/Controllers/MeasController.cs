using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;
using DesignStudioErp.WebApi.Dtos.MeasDto;
using Microsoft.AspNetCore.Mvc;

namespace DesignStudioErp.WebApi.Controllers;

/// <summary>
/// Meas
/// </summary>
public class MeasController : BaseController
{
    private readonly IRepo<Meas> _repo;

    public MeasController(IRepo<Meas> repo)
    {
        _repo = repo ?? throw new ArgumentNullException(nameof(repo));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MeasReadDto>>> GetAllAsync()
    {
        var meas = await _repo.GetAllAsync();

        var measDto = Mapper.Map<MeasReadDto>(meas);

        return Ok(measDto);
    }


}
