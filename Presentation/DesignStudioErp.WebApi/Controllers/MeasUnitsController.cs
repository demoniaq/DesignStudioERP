using DesignStudioErp.Application.HandBooks;
using DesignStudioErp.Application.Interfaces.Services;
using DesignStudioErp.Dto.MeasDto;
using DesignStudioErp.WebApi.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DesignStudioErp.WebApi.Controllers;

/// <summary>
/// Meas
/// </summary>
public class MeasUnitsController : BaseController
{
    private readonly IMeasUnitService _measUnitService;

    public MeasUnitsController(IMeasUnitService measUnitService)
    {
        _measUnitService = measUnitService ?? throw new ArgumentNullException(nameof(measUnitService));
    }

    /// <summary>
    /// Get all meas units
    /// </summary>
    [HttpGet]
    [SwaggerResponse((int)ApiStatusCode.OK, Type = typeof(IEnumerable<MeasUnitReadDto>))]
    public async Task<ActionResult<IEnumerable<MeasUnitReadDto>>> GetAllAsync()
    {
        //var measUnits = await _repository.GetAllAsync();
        var measUnits = await _measUnitService.GetAllAsync();

        var measUnitsDto = Mapper.Map<IEnumerable<MeasUnitReadDto>>(measUnits);

        return Ok(measUnitsDto);
    }

    /// <summary>
    /// Get meas unit by id
    /// </summary>
    [HttpGet("{id}")]
    [SwaggerResponse((int)ApiStatusCode.OK, Type = typeof(MeasUnitReadDto))]
    public async Task<ActionResult<MeasUnitReadDto>> GetMeasUnitByIdAsync([FromRoute] Guid id)
    {
        var measUnit = await _measUnitService.GetByIdAsync(id);

        var measUnitDto = Mapper.Map<MeasUnitReadDto>(measUnit);

        return Ok(measUnitDto);
    }
}