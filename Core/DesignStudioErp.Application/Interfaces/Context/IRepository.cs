using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Interfaces.Context;

/// <summary>
/// Generic interface for repositories
/// </summary>
public interface IRepository<TEntity> where TEntity : BaseModel
{
    /// <summary>
    /// Save changes
    /// </summary>
    Task SaveChangesAsync();

    /// <summary>
    /// Get all entities
    /// </summary>
    IQueryable<TEntity> GetAll();

    /// <summary>
    /// Get all entities async
    /// </summary>
    Task<IEnumerable<TEntity>> GetAllAsync();

    /// <summary>
    /// Get entities by condition
    /// </summary>
    Task<IEnumerable<TEntity>> GetAllByConditionAsync(Func<TEntity, bool> predicate);

    /// <summary>
    /// Get entity by id
    /// </summary>
    Task<TEntity> GetByIdAsync(Guid id);

    /// <summary>
    /// Create entity
    /// </summary>
    Task CreateAsync(TEntity entity);

    /// <summary>
    /// Update entity
    /// </summary>
    Task UpdateAsync(TEntity entity);

    /// <summary>
    /// Delete entity
    /// </summary>
    Task DeleteAsync(TEntity entity);
}