using DesignStudioErp.Domain;
using DesignStudioErp.WebApi.Dtos.MaterialDto;
using Microsoft.AspNetCore.Mvc;

namespace DesignStudioErp.WebApi.Controllers;

/// <summary>
/// Единицы измерения
/// </summary>
public class MeasController : BaseController
{
    [HttpPost]
    //[SwaggerResponse((int)ApiHttpStatusCode.Created, Type = typeof(MaterialCreateDto))]
    public ActionResult<MaterialReadDto> CreateMaterial([FromBody] MaterialCreateDto materialCreateDto)
    {
        Material material = Mapper.Map<Material>(materialCreateDto);


        MaterialReadDto materialReadDto = default;

        return CreatedAtRoute(nameof(GetOrderByIdAsync),
                              new { id = materialReadDto.Id },
                              materialReadDto);
    }


}
