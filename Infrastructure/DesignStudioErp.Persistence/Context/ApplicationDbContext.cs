using DesignStudioErp.Domain;
using DesignStudioErp.Persistence.EntityConfigurations;
using DesignStudioErp.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesignStudioErp.Persistence.Context;

/// <summary>
/// Db context
/// </summary>
public class ApplicationDbContext : DbContext, IApplicationContext
{
    /// <summary>
    /// ctor
    /// </summary>
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    /// <summary>
    /// Apply configurations
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MaterialConfiguration());
        modelBuilder.ApplyConfiguration(new MeasUnitConfiguration());

        base.OnModelCreating(modelBuilder);
    }

    #region DbSets
    public DbSet<MeasUnit>? MeasUnits { get; set; }
    public DbSet<Material>? Materials { get; set; }
    #endregion DbSets

}
