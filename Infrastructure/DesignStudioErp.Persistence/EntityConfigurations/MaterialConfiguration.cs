using DesignStudioErp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesignStudioErp.Persistence.EntityConfigurations;

internal class MaterialConfiguration : BaseEntityConfiguration<Material>, IEntityTypeConfiguration<Material>
{
    public override void Configure(EntityTypeBuilder<Material> builder)
    {
        base.Configure(builder);

        #region Name
        builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(255);
        #endregion Name

        #region MeasUnit
        builder.Property(e => e.MeasUnitId)
            .IsRequired()
            .HasColumnType("uniqueidentifier");

        builder.HasOne(x => x.MeasUnit)
            .WithMany()
            .HasForeignKey(x => x.MeasUnitId)
            .OnDelete(DeleteBehavior.Cascade);
        #endregion MeasUnit
    }
}
