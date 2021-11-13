using DesignStudioErp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesignStudioErp.Persistence.EntityTypeConfiguration
{
    internal class MaterialConfiguration : BaseEntityConfiguration<Material>, IEntityTypeConfiguration<Material>
    {
        public override void Configure(EntityTypeBuilder<Material> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(255);
        }
    }
}
