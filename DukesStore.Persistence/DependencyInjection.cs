using DukesStore.ApplicationCore.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DukesStore.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection service, IConfiguration config)
        {
            service.AddDbContext<DukesEShopContext>(options => options.UseSqlServer(config.GetConnectionString("DukesEShop")));
            service.AddScoped<IDukesEShopContext,DukesEShopContext>();
            return service;
        }
    }
}
