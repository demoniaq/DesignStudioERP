using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;
using Microsoft.EntityFrameworkCore;

namespace DesignStudioErp.Application.Repo;

/// <summary>
/// Generic repository
/// </summary>
/// <typeparam name="T"></typeparam>
public class Repo<T> : IRepo<T> where T : BaseModel
{
    private readonly IApplicationDbContext? _context;
    private readonly DbSet<T> _entities;

    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="context"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public Repo(IApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _entities = _context.Set<T>() ?? throw new NullReferenceException(nameof(_entities));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var entities = await _entities.ToListAsync();
        return entities;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task<IEnumerable<T>> GetAllByConditionAsync(Func<T, bool> predicate)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<T> GetByIdAsync(Guid id)
    {
        var entity = await _entities.FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task CreateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
