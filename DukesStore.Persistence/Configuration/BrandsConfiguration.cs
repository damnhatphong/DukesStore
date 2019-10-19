using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DukesStore.Persistence.Configuration
{
    public class BrandsConfiguration : IEntityTypeConfiguration<Brands>
    {
        public void Configure(EntityTypeBuilder<Brands> entity)
        {
            entity.HasKey(e => e.BrandId)
                   .HasName("PK__brands__5E5A8E27D7920438");

            entity.ToTable("brands", "production");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");

            entity.Property(e => e.BrandName)
                .IsRequired()
                .HasColumnName("brand_name")
                .HasMaxLength(255)
                .IsUnicode(false);
        }
    }
}
