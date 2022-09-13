using DesignStudioErp.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DesignStudioErp.Persistence.Interfaces.Context;

public interface IApplicationContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    DbSet<TEntity>? Set<TEntity>() where TEntity : class;
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

    #region DbSets
    DbSet<MeasUnit>? MeasUnits { get; set; }
    DbSet<Material>? Materials { get; set; }
    #endregion DbSets
}