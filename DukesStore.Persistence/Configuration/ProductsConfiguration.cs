using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DukesStore.Persistence.Configuration
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> entity)
        {
            entity.HasKey(e => e.ProductId)
                    .HasName("PK__products__47027DF565E8B779");

            entity.ToTable("products", "production");

            entity.Property(e => e.ProductId).HasColumnName("product_id");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");

            entity.Property(e => e.ModelYear).HasColumnName("model_year");

            entity.Property(e => e.PriceId).HasColumnName("price_id");

            entity.Property(e => e.Description)
                .HasColumnName("product_description")
                .HasMaxLength(500)
                .IsUnicode();

            entity.Property(e => e.ProductName)
                .IsRequired()
                .HasColumnName("product_name")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Brand)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK__products__brand___412EB0B6");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__products__price___403A8C7D");

            entity.HasOne(d => d.Price)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.PriceId)
                .HasConstraintName("FK__products__price___4222D4EF");
        }
    }
}
