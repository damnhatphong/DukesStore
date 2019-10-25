using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace DukesStore.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IdentityApplicationContext>(options =>
                  options.UseSqlServer(
                      configuration.GetConnectionString("IdentityApplicationContextConnection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<IdentityApplicationContext>();

            services.AddAuthentication().AddExternalAuthenticationServices(configuration);


            return services;
        }
    }
}
