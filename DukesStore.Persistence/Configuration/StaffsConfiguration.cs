using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DukesStore.Persistence.Configuration
{
    public class StaffsConfiguration : IEntityTypeConfiguration<Staffs>
    {
        public void Configure(EntityTypeBuilder<Staffs> entity)
        {
            entity.HasKey(e => e.StaffId)
                    .HasName("PK__staffs__1963DD9C6436288A");

            entity.ToTable("staffs", "sales");

            entity.HasIndex(e => e.Email)
                .HasName("UQ__staffs__AB6E616469570119")
                .IsUnique();

            entity.Property(e => e.StaffId).HasColumnName("staff_id");

            entity.Property(e => e.Active).HasColumnName("active");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnName("first_name")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("last_name")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ManagerId).HasColumnName("manager_id");

            entity.Property(e => e.Phone)
                .HasColumnName("phone")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.StoreId).HasColumnName("store_id");

            entity.HasOne(d => d.Manager)
                .WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK__staffs__manager___49C3F6B7");

            entity.HasOne(d => d.Store)
                .WithMany(p => p.Staffs)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK__staffs__store_id__48CFD27E");
        }
    }
}
