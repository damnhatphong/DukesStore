using DukesStore.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DukesStore.Persistence
{
    public static class ModelBuilderExtensions
    {
        public static void ApplyAllConfiguration(this ModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces()
            .Any(gi => gi.IsGenericType && gi.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))).ToList();

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
        }


        public static void SeedingData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>().HasData(
                new Brands { BrandId = 1, BrandName = "Apple" },
                new Brands { BrandId = 2, BrandName = "SamSung" },
                new Brands { BrandId = 3, BrandName = "Sony" },
                new Brands { BrandId = 4, BrandName = "Huawei" },
                new Brands { BrandId = 5, BrandName = "Xiaomi" },
                new Brands { BrandId = 6, BrandName = "Microsoft" }
            );

            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryId = 1, CategoryName = "Phone" },
                new Categories { CategoryId = 2, CategoryName = "Tablet" },
                new Categories { CategoryId = 3, CategoryName = "Laptop" },
                new Categories { CategoryId = 4, CategoryName = "Head Phone" },
                new Categories { CategoryId = 5, CategoryName = "Smart Watch" }
            );

            modelBuilder.Entity<Currency>().HasData(
                new Currency { CurrencyId = 1, CurrencyUnit = "USD", CreatedDate = DateTime.Today },
                new Currency { CurrencyId = 2, CurrencyUnit = "VND", CreatedDate = DateTime.Today }
            );

            modelBuilder.Entity<Prices>().HasData(
                new Prices { PriceId = 1, Amount = 999.9M, CurrencyId = 1, CreatedDate = DateTime.Today, EffectiveDate = DateTime.Today, Description = "Discription" },
                new Prices { PriceId = 2, Amount = 699.9M, CurrencyId = 1, CreatedDate = DateTime.Today, EffectiveDate = DateTime.Today, Description = "Discription" },
                new Prices { PriceId = 3, Amount = 599.9M, CurrencyId = 1, CreatedDate = DateTime.Today, EffectiveDate = DateTime.Today, Description = "Discription" },
                new Prices { PriceId = 4, Amount = 1499.9M, CurrencyId = 1, CreatedDate = DateTime.Today, EffectiveDate = DateTime.Today, Description = "Discription" },
                new Prices { PriceId = 5, Amount = 2599.9M, CurrencyId = 1, CreatedDate = DateTime.Today, EffectiveDate = DateTime.Today, Description = "Discription" },
                new Prices { PriceId = 6, Amount = 399.9M, CurrencyId = 1, CreatedDate = DateTime.Today, EffectiveDate = DateTime.Today, Description = "Discription" }
            );

            modelBuilder.Entity<Products>().HasData(
                new Products { ProductId = 1, ProductName = "IPhone 11 Pro", BrandId = 1, CategoryId = 1, ModelYear = 2019, PriceId = 1, Description= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                new Products { ProductId = 2, ProductName = "Galaxy Note10", BrandId = 2, CategoryId = 1, ModelYear = 2019, PriceId = 1, Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." }
            );

        }
    }
}
