namespace DesignStudioErp.Domain;

/// <summary>
/// Abstract base model
/// </summary>
public abstract class BaseModel
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Creation date
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Edit date
    /// </summary>
    public DateTime? EditDate { get; set; }
}
