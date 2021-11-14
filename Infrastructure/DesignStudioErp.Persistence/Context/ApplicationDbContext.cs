using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;
using DesignStudioErp.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace DesignStudioErp.Persistence.Context;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MaterialConfiguration());
        modelBuilder.ApplyConfiguration(new MeasUnitConfiguration());

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Material>? Materials { get; set; }
    public DbSet<MeasUnit>? MeasUnits { get; set; }
}
