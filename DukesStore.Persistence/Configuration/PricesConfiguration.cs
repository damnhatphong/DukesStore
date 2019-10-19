using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DukesStore.Persistence.Configuration
{
    public class PricesConfiguration : IEntityTypeConfiguration<Prices>
    {
        public void Configure(EntityTypeBuilder<Prices> entity)
        {
            entity.HasKey(e => e.PriceId)
                     .HasName("PK__prices__1681726D53E1AE73");

            entity.ToTable("prices", "production");

            entity.Property(e => e.PriceId).HasColumnName("price_id");

            entity.Property(e => e.Amount)
                .HasColumnName("amount")
                .HasColumnType("smallmoney");

            entity.Property(e => e.CreatedDate).HasColumnName("created_date");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("description")
                .HasColumnType("text");

            entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");
        }
    }
}
