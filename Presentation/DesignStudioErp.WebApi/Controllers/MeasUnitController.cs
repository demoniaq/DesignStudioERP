using System.ComponentModel.DataAnnotations;

using DesignStudioErp.Application.HandBooks;
using DesignStudioErp.Application.Interfaces.Services;
using DesignStudioErp.Dto.MeasDto;
using DesignStudioErp.WebApi.Controllers.Base;

using Microsoft.AspNetCore.Mvc;

using Swashbuckle.AspNetCore.Annotations;

namespace DesignStudioErp.WebApi.Controllers;

/// <summary>
/// MeasUnit
/// </summary>
public class MeasUnitController : BaseController
{
    private readonly IMeasUnitService _measUnitService;

    public MeasUnitController(IMeasUnitService measUnitService)
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
        var measUnits = await _measUnitService.GetAllAsync();
        var measUnitsDtos = Mapper.Map<IEnumerable<MeasUnitReadDto>>(measUnits);

        return Ok(measUnitsDtos);
    }

    /// <summary>
    /// Get meas unit by id
    /// </summary>
    [HttpGet("{id}")]
    [SwaggerResponse((int)ApiStatusCode.OK, Type = typeof(MeasUnitReadDto))]
    public async Task<ActionResult<MeasUnitReadDto>> GetMeasUnitByIdAsync([FromRoute, Required] Guid id)
    {
        var measUnit = await _measUnitService.GetByIdAsync(id);
        var measUnitDto = Mapper.Map<MeasUnitReadDto>(measUnit);

        return Ok(measUnitDto);
    }
}