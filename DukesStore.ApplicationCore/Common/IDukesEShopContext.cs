using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace DukesStore.ApplicationCore.Common
{
    public interface IDukesEShopContext
    {
        DbSet<Brands> Brands { get; set; }
        DbSet<Categories> Categories { get; set; }
        DbSet<Customers> Customers { get; set; }
        DbSet<OrderItems> OrderItems { get; set; }
        DbSet<Orders> Orders { get; set; }
        DbSet<Prices> Prices { get; set; }
        DbSet<Products> Products { get; set; }
        DbSet<Staffs> Staffs { get; set; }
        DbSet<Stocks> Stocks { get; set; }
        DbSet<Stores> Stores { get; set; }
        DbSet<Currency> Currencies { get; set; }
        Task<int> SaveChangesAsync();

        void Update(object entity);

    }
}
