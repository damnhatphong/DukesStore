using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DukesStore.Persistence.Configuration
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> entity)
        {
            entity.HasKey(e => e.CategoryId)
                .HasName("PK__categori__D54EE9B467C10685");

            entity.ToTable("categories", "production");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");

            entity.Property(e => e.CategoryName)
                .IsRequired()
                .HasColumnName("category_name")
                .HasMaxLength(255)
                .IsUnicode(false);
        }
    }
}
