using DesignStudioErp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesignStudioErp.Persistence.EntityConfigurations
{
    internal abstract class BaseEntityConfiguration<TBaseModel> : IEntityTypeConfiguration<TBaseModel> where TBaseModel : BaseModel
    {
        public virtual void Configure(EntityTypeBuilder<TBaseModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(x => x.Id)
                   .IsRequired()
                   .ValueGeneratedOnAdd();

            builder.Property(e => e.CreationDate)
                   .IsRequired();

        }
    }
}
