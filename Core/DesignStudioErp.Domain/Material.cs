namespace DesignStudioErp.Domain;

/// <summary>
/// Material
/// </summary>
public class Material : BaseModel
{
    /// <summary>
    /// Ctor
    /// </summary>
    /// <param name="name"></param>
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
    public Guid MeasId { get; set; }


}
