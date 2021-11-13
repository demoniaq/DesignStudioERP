namespace DesignStudioErp.WebApi.Dtos.MaterialDto;

internal abstract class MaterialBaseDto
{
    /// <summary>
    /// Название материала
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// FK единица изменения
    /// </summary>
    public Guid MeasId { get; set; }
}
