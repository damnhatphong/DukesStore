using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DukesStore.Persistence.Configuration
{
    public class OrderItemsConfiguration : IEntityTypeConfiguration<OrderItems>
    {
        public void Configure(EntityTypeBuilder<OrderItems> entity)
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("PK__order_it__022945F6D924F325");

            entity.ToTable("order_items", "sales");

            entity.Property(e => e.OrderId).HasColumnName("order_id");

            entity.Property(e => e.ProductId).HasColumnName("product_id");

            entity.Property(e => e.Discount)
                .HasColumnName("discount")
                .HasColumnType("decimal(4, 2)");

            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.Property(e => e.TotalPrice)
                .HasColumnName("total_price")
                .HasColumnType("smallmoney");

            entity.HasOne(d => d.Order)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__order_ite__order__52593CB8");

            entity.HasOne(d => d.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__order_ite__produ__534D60F1");
        }
    }
}
