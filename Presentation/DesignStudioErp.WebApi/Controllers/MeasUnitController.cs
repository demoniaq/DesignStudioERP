using DesignStudioErp.Application.HandBooks;
using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;
using DesignStudioErp.Dto.MeasDto;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DesignStudioErp.WebApi.Controllers;

/// <summary>
/// Meas
/// </summary>
public class MeasUnitController : BaseController
{
    private readonly IRepo<MeasUnit> _repo;

    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="repo"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public MeasUnitController(IRepo<MeasUnit> repo)
    {
        _repo = repo ?? throw new ArgumentNullException(nameof(repo));
    }

    /// <summary>
    /// Get all meas units
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [SwaggerResponse((int)ApiStatusCode.OK, Type = typeof(IEnumerable<MeasUnitReadDto>))]
    public async Task<ActionResult<IEnumerable<MeasUnitReadDto>>> GetAllAsync()
    {
        var measUnits = await _repo.GetAllAsync();

        var measUnitsDtos = Mapper.Map<IEnumerable<MeasUnitReadDto>>(measUnits);

        return Ok(measUnitsDtos);
    }

    /// <summary>
    /// Get meas unit by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    [SwaggerResponse((int)ApiStatusCode.OK, Type = typeof(MeasUnitReadDto))]
    public async Task<ActionResult<MeasUnitReadDto>> GetMeasUnitByIdAsync([FromRoute] Guid id)
    {
        var measUnit = await _repo.GetByIdAsync(id);

        var measUnitsDto = Mapper.Map<MeasUnitReadDto>(measUnit);

        return Ok(measUnitsDto);
    }


}
