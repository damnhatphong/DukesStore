using DukesStore.ApplicationCore.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DukesStore.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<DukesEShopContext>(options => options.UseSqlServer(configuration.GetConnectionString("DukesEShop")));
            service.AddScoped<IDukesEShopContext,DukesEShopContext>();
            return service;
        }
    }
}
