using Microsoft.AspNetCore.Mvc;

namespace DesignStudioErp.WebApi.Controllers;

public class MaterialController : BaseController
{

    [HttpGet]
    public async Task<ActionResult> GetAll()
    {

        return Ok();
    }

}

