﻿using DesignStudioErp.Application.Interfaces.Context;
using DesignStudioErp.Domain;
using Microsoft.EntityFrameworkCore;

namespace DesignStudioErp.Persistence.Repository;

/// <summary>
/// Generic repository
/// </summary>
public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
{
    private readonly IApplicationContext _context;
    private readonly DbSet<TEntity> _dbSet;

    /// <summary>
    /// ctor
    /// </summary>
    public Repository(IApplicationContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<TEntity>() ?? throw new NullReferenceException(nameof(_dbSet));
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
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
#pragma warning disable IDE0059 // Ненужное присваивание значения
#pragma warning disable CS0168 // Переменная объявлена, но не используется
        catch (DbUpdateException updateException)
#pragma warning restore CS0168 // Переменная объявлена, но не используется
#pragma warning restore IDE0059 // Ненужное присваивание значения
        {
            // TODO add error check
            throw;
        }
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<IEnumerable<TEntity>> GetAllByConditionAsync(Func<TEntity, bool> predicate)
    {
        var query = _dbSet.Where(predicate).AsQueryable();
        return await query.AsNoTracking().ToListAsync();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<TEntity> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        // TODO add check error for not found
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        return entity;
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task CreateAsync(TEntity entity)
    {
        entity.CreationDate = DateTime.Now; // TODO temporary, do datetime service
        _dbSet.Add(entity);
        await SaveChangesAsync();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task UpdateAsync(TEntity entity)
    {
        entity.EditDate = DateTime.Now; // TODO temporary, do datetime service
        _context.Entry(entity).State = EntityState.Modified;
        await SaveChangesAsync();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task DeleteAsync(TEntity entity)
    {
        _dbSet.Remove(entity);
        await SaveChangesAsync();
    }
}
