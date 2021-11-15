using System.ComponentModel.DataAnnotations;

namespace DesignStudioErp.Dto.MeasDto;

public abstract class MeasUnitBaseDto
{
    /// <summary>
    /// Meas name
    /// </summary>
    [Required]
    public string? Name { get; set; }

}
