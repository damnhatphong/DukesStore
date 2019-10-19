using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DukesStore.Persistence.Configuration
{
    public class StocksConfiguration : IEntityTypeConfiguration<Stocks>
    {
        public void Configure(EntityTypeBuilder<Stocks> entity)
        {
            entity.HasKey(e => new { e.StoreId, e.ProductId })
                   .HasName("PK__stocks__E68284D364CBE4C9");

            entity.ToTable("stocks", "production");

            entity.Property(e => e.StoreId).HasColumnName("store_id");

            entity.Property(e => e.ProductId).HasColumnName("product_id");

            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Product)
                .WithMany(p => p.Stocks)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__stocks__product___571DF1D5");

            entity.HasOne(d => d.Store)
                .WithMany(p => p.Stocks)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__stocks__store_id__5629CD9C");
        }
    }
}
