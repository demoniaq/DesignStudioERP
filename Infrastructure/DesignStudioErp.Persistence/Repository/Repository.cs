using DesignStudioErp.Application.Interfaces.Context;
using DesignStudioErp.Domain;
using DesignStudioErp.Persistence.Interfaces.Context;

using Microsoft.EntityFrameworkCore;

namespace DesignStudioErp.Persistence.Repository;

/// <summary>
/// Generic repository
/// </summary>
public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
{
    private readonly IApplicationContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(IApplicationContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<TEntity>() ?? throw new NullReferenceException(nameof(_dbSet));
    }

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
        catch // (DbUpdateException updateException)
        {
            // TODO add error check
            throw;
        }
    }

    public IQueryable<TEntity> GetAll() => _dbSet.AsQueryable();

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    public async Task<IEnumerable<TEntity>> GetAllByConditionAsync(Func<TEntity, bool> predicate)
    {
        var query = _dbSet.Where(predicate).AsQueryable();
        return await query.AsNoTracking().ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        // TODO add check error for not found

        return entity;
    }

    public async Task CreateAsync(TEntity entity)
    {
        entity.CreationDate = DateTime.Now; // TODO temporary, do DateTime service
        _dbSet.Add(entity);
        await SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        entity.EditDate = DateTime.Now; // TODO temporary, do DateTime service
        _context.Entry(entity).State = EntityState.Modified;
        await SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _dbSet.Remove(entity);
        await SaveChangesAsync();
    }
}