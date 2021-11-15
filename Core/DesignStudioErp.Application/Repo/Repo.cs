using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;
using Microsoft.EntityFrameworkCore;

namespace DesignStudioErp.Application.Repo;

/// <summary>
/// Generic repository
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public class Repo<TEntity> : IRepo<TEntity> where TEntity : BaseModel
{
    private readonly IApplicationContext _context;
    private readonly DbSet<TEntity> _dbSet;

    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="context"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public Repo(IApplicationContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<TEntity>() ?? throw new NullReferenceException(nameof(_dbSet));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns></returns>
    public async Task SaveChangesAsync()
    {
        try
        {
            var result = await _context.SaveChangesAsync(new CancellationToken());
            if (result != 0)
            {
                // TODO error
            }
        }
        catch (DbUpdateException updateException)
        {
            // TODO add error check
            throw;
        }
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    public async Task<IEnumerable<TEntity>> GetAllByConditionAsync(Func<TEntity, bool> predicate)
    {
        var query = _dbSet.Where(predicate).AsQueryable();
        return await query.AsNoTracking().ToListAsync();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<TEntity> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        // TODO add check error for not found
        return entity;
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task CreateAsync(TEntity entity)
    {
        entity.CreationDate = DateTime.Now; // TODO temporary, do datetime service
        _dbSet.Add(entity);
        await SaveChangesAsync();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task UpdateAsync(TEntity entity)
    {
        entity.EditDate = DateTime.Now; // TODO temporary, do datetime service
        _context.Entry(entity).State = EntityState.Modified;
        await SaveChangesAsync();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task DeleteAsync(TEntity entity)
    {
        _dbSet.Remove(entity);
        await SaveChangesAsync();
    }
}
