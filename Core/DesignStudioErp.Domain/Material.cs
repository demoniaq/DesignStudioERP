namespace DesignStudioErp.Domain;

/// <summary>
/// Material
/// </summary>
public class Material : BaseModel
{
    public Material(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Name of material
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// FK to meas
    /// </summary>
    public Guid MeasUnitId { get; set; }

    /// <summary>
    /// Meas unit
    /// </summary>
    public MeasUnit? MeasUnit { get; set; }
}