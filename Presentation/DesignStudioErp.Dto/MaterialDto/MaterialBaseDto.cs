using System.ComponentModel.DataAnnotations;

namespace DesignStudioErp.Dto.MaterialDto;

public abstract class MaterialBaseDto
{
    /// <summary>
    /// Material name
    /// </summary>
    [Required]
    public string? Name { get; set; }

    /// <summary>
    /// FK meas
    /// </summary>
    [Required]
    public Guid MeasUnitId { get; set; }
}