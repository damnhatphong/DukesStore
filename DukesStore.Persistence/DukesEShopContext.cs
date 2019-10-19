using System;
using System.Threading;
using System.Threading.Tasks;
using DukesStore.ApplicationCore.Common;
using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DukesStore.Persistence
{
    public partial class DukesEShopContext : DbContext,IDukesEShopContext
    {
        public DukesEShopContext()
        {
        }

        public DukesEShopContext(DbContextOptions<DukesEShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Prices> Prices { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Staffs> Staffs { get; set; }
        public virtual DbSet<Stocks> Stocks { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        void IDukesEShopContext.Update(object entity)
        {
            base.Update(entity);
        }
        /*
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
            modelBuilder.ApplyAllConfiguration();
            modelBuilder.SeedingData();
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(DukesEShopContext).Assembly);
        }

      
    }
}
