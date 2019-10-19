using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DukesStore.Persistence.Configuration
{
    public class StoresConfiguration : IEntityTypeConfiguration<Stores>
    {
        public void Configure(EntityTypeBuilder<Stores> entity)
        {
            entity.HasKey(e => e.StoreId)
                   .HasName("PK__stores__A2F2A30C53407733");

            entity.ToTable("stores", "sales");

            entity.HasIndex(e => e.Email)
                .HasName("UQ__stores__AB6E61648E182554")
                .IsUnique();

            entity.Property(e => e.StoreId).HasColumnName("store_id");

            entity.Property(e => e.City)
                .HasColumnName("city")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.District)
                .HasColumnName("district")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("email")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasColumnName("phone")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.StoreName)
                .IsRequired()
                .HasColumnName("store_name")
                .HasMaxLength(255)
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
