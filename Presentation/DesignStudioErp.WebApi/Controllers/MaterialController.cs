using Microsoft.AspNetCore.Mvc;

namespace DesignStudioErp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MaterialController : ControllerBase
{
    private readonly ILogger<MaterialController> _logger;

    public MaterialController(ILogger<MaterialController> logger)
    {
        _logger = logger;
    }

    //[HttpGet(Name = "GetMaterials")]
    /*
    public IEnumerable<Material> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    */
}
