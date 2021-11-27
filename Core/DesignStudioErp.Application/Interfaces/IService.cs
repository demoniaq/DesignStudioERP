using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Interfaces;

public interface IService<TEntity> where TEntity : BaseModel
{
    /// <summary>
    /// Get all entities
    /// </summary>
    Task<IEnumerable<TEntity>> GetAllAsync();

    /// <summary>
    /// Get entity by id
    /// </summary>
    Task<TEntity> GetByIdAsync(Guid id);
}

