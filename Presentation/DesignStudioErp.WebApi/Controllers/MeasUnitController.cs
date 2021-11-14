using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;
using DesignStudioErp.WebApi.Dtos.MeasDto;
using Microsoft.AspNetCore.Mvc;

namespace DesignStudioErp.WebApi.Controllers;

/// <summary>
/// Meas
/// </summary>
public class MeasUnitController : BaseController
{
    private readonly IRepo<MeasUnit> _repo;

    public MeasUnitController(IRepo<MeasUnit> repo)
    {
        _repo = repo ?? throw new ArgumentNullException(nameof(repo));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MeasUnitReadDto>>> GetAllAsync()
    {
        var measUnits = await _repo.GetAllAsync();

        var measUnitsDtos = Mapper.Map<IEnumerable<MeasUnitReadDto>>(measUnits);

        return Ok(measUnitsDtos);
    }


}
