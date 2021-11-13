using DesignStudioErp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesignStudioErp.Persistence.EntityConfigurations
{
    internal class MeasConfiguration : BaseEntityConfiguration<Meas>, IEntityTypeConfiguration<Meas>
    {
        public override void Configure(EntityTypeBuilder<Meas> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
