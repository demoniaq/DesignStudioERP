using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;
using DesignStudioErp.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace DesignStudioErp.Persistence.Context;

/// <summary>
/// Db context
/// </summary>
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="options"></param>
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    /// <summary>
    /// Aplly configurations
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MaterialConfiguration());
        modelBuilder.ApplyConfiguration(new MeasUnitConfiguration());

        base.OnModelCreating(modelBuilder);
    }

    #region DbSets
    public DbSet<Material>? Materials { get; set; }
    public DbSet<MeasUnit>? MeasUnits { get; set; }
    #endregion DbSets

}
