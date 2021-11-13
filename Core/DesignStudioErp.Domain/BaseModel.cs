namespace DesignStudioErp.Domain;

/// <summary>
/// Базовая модель
/// </summary>
public abstract class BaseModel
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Дата-время создания
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Дата-время редактирования
    /// </summary>
    public DateTime? EditDate { get; set; }
}
