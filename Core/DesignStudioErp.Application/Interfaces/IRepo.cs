using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Interfaces;

/// <summary>
/// Generic interface for repositories
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IRepo<TEntity> where TEntity : BaseModel
{
    /// <summary>
    /// Save changes
    /// </summary>
    /// <returns></returns>
    Task SaveChangesAsync();

    /// <summary>
    /// Get all entities
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<TEntity>> GetAllAsync();

    /// <summary>
    /// Get entities by condition
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    Task<IEnumerable<TEntity>> GetAllByConditionAsync(Func<TEntity, bool> predicate);

    /// <summary>
    /// Get entity by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<TEntity> GetByIdAsync(Guid id);

    /// <summary>
    /// Create entity
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task CreateAsync(TEntity entity);

    /// <summary>
    /// Update entity
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task UpdateAsync(TEntity entity);

    /// <summary>
    /// Delete entity
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task DeleteAsync(TEntity entity);
}
