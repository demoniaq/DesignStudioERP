using System.ComponentModel.DataAnnotations;

namespace DesignStudioErp.WebApi.Dtos.MeasDto;

public abstract class MeasUnitBaseDto
{
    /// <summary>
    /// Meas name
    /// </summary>
    [Required]
    public string? Name { get; set; }

}
