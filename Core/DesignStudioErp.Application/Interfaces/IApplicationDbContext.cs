using DesignStudioErp.Domain;
using Microsoft.EntityFrameworkCore;

namespace DesignStudioErp.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Material>? Materials { get; set; }
    DbSet<Meas>? Meas { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
