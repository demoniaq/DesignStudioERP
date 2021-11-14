namespace DesignStudioErp.WebApi.Dtos.MaterialDto;

public abstract class MaterialBaseDto
{
    /// <summary>
    /// Materail name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// FK meas
    /// </summary>
    public Guid MeasId { get; set; }
}
