using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DukesStore.Persistence.Configuration
{
    public class CustomersConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> entity)
        {
            entity.HasKey(e => e.CustomerId)
                    .HasName("PK__customer__CD65CB857BC22627");

            entity.ToTable("customers", "sales");

            entity.HasIndex(e => e.Email)
                .HasName("UQ__customer__AB6E6164AF8A0B90")
                .IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");

            entity.Property(e => e.City)
                .HasColumnName("city")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.District)
                .HasColumnName("district")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnName("first_name")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("last_name")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasColumnName("phone")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.Street)
                .HasColumnName("street")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Ward)
                .HasColumnName("ward")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("zip_code")
                .HasMaxLength(5)
                .IsUnicode(false);
        }
    }
}
