using DesignStudioErp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesignStudioErp.Persistence.EntityConfigurations;

internal class MeasUnitConfiguration : BaseEntityConfiguration<MeasUnit>, IEntityTypeConfiguration<MeasUnit>
{
    public override void Configure(EntityTypeBuilder<MeasUnit> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(50);

    }
}
