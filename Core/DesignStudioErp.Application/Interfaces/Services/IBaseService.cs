using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Interfaces.Services;

public interface IBaseService<TEntity> where TEntity : BaseModel
{
    /// <summary>
    /// Get all entities
    /// </summary>
    IQueryable<TEntity> GetAll();

    /// <summary>
    /// Get all entities async
    /// </summary>
    Task<IEnumerable<TEntity>> GetAllAsync();

    /// <summary>
    /// Get entity by id
    /// </summary>
    Task<TEntity> GetByIdAsync(Guid id);
}