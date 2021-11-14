namespace DesignStudioErp.Domain;

/// <summary>
/// Meas
/// </summary>
public class MeasUnit : BaseModel
{
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="name"></param>
    public MeasUnit(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Name of meas
    /// </summary>
    public string Name { get; set; }

}
