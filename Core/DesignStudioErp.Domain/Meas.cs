namespace DesignStudioErp.Domain;

/// <summary>
/// Единица измерения
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
    /// Название единицы измерения
    /// </summary>
    public string Name { get; set; }

}
