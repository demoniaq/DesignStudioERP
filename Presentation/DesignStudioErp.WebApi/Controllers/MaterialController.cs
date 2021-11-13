using DesignStudioErp.WebApi.Dtos.MaterialDto;
using Microsoft.AspNetCore.Mvc;

namespace DesignStudioErp.WebApi.Controllers;

/// <summary>
/// Материалы
/// </summary>
public class MaterialController : BaseController
{

    [HttpGet]
    public ActionResult<IEnumerable<MaterialReadDto>> GetAll()
    {

        IEnumerable<MaterialReadDto> materialReadDtos = new List<MaterialReadDto>();

        return Ok(materialReadDtos);
    }

}

