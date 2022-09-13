using DesignStudioErp.Application.HandBooks;
using DesignStudioErp.Application.Interfaces.Services;
using DesignStudioErp.Dto.MaterialDto;
using DesignStudioErp.WebApi.Controllers.Base;

using Microsoft.AspNetCore.Mvc;

using Swashbuckle.AspNetCore.Annotations;

namespace DesignStudioErp.WebApi.Controllers;

/// <summary>
/// Material
/// </summary>
public class MaterialController : BaseController
{
    private readonly IMaterialService _materialService;

    public MaterialController(IMaterialService materialService)
    {
        _materialService = materialService ?? throw new ArgumentNullException(nameof(materialService));
    }

    /// <summary>
    /// Get all materials
    /// </summary>
    [HttpGet]
    [SwaggerResponse((int)ApiStatusCode.OK, Type = typeof(IEnumerable<MaterialReadDto>))]
    public async Task<ActionResult<IEnumerable<MaterialReadDto>>> GetAllAsync()
    {
        var materials = await _materialService.GetAllMaterialWithMeasUnitNameAsync();

        var materialDtos = Mapper.Map<IEnumerable<MaterialReadDto>>(materials);

        return Ok(materialDtos);
    }
}