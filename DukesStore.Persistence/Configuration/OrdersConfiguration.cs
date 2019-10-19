using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DukesStore.Persistence.Configuration
{
    public class OrdersConfiguration : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> entity)
        {
            entity.HasKey(e => e.OrderId)
                    .HasName("PK__orders__46596229E1A61EA0");

            entity.ToTable("orders", "sales");

            entity.Property(e => e.OrderId).HasColumnName("order_id");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");

            entity.Property(e => e.OrderDate)
                .HasColumnName("order_date")
                .HasColumnType("date");

            entity.Property(e => e.OrderStatus).HasColumnName("order_status");

            entity.Property(e => e.RequiredDate)
                .HasColumnName("required_date")
                .HasColumnType("date");

            entity.Property(e => e.ShippedDate)
                .HasColumnName("shipped_date")
                .HasColumnType("date");

            entity.Property(e => e.StaffId).HasColumnName("staff_id");

            entity.Property(e => e.StoreId).HasColumnName("store_id");

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__orders__customer__4CA06362");

            entity.HasOne(d => d.Staff)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__orders__staff_id__4E88ABD4");

            entity.HasOne(d => d.Store)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__orders__store_id__4D94879B");
        }
    }
}
