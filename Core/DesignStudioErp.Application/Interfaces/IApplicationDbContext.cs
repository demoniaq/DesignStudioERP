using DesignStudioErp.Domain;
using Microsoft.EntityFrameworkCore;

namespace DesignStudioErp.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Material>? Materials { get; set; }
    DbSet<MeasUnit>? MeasUnits { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    
    DbSet<TEntity>? Set<TEntity>() where TEntity : class;
}
