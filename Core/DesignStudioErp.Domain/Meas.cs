namespace DesignStudioErp.Domain;

/// <summary>
/// Meas
/// </summary>
public class Meas : BaseModel
{
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="name"></param>
    public Meas(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Name of meas
    /// </summary>
    public string Name { get; set; }

}
