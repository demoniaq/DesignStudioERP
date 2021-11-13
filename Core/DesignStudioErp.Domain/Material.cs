namespace DesignStudioErp.Domain;

/// <summary>
/// Материал
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
    /// Название материала
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// FK единица изменения
    /// </summary>
    public Guid MeasId { get; set; }


}
