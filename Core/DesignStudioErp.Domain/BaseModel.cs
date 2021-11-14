namespace DesignStudioErp.Domain;

public abstract class BaseModel
{
    public Guid Id { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? EditDate { get; set; }
}
