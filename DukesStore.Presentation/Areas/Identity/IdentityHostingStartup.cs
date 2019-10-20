using System;
using DukesStore.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DukesStore.Presentation.Areas.Identity.IdentityHostingStartup))]
namespace DukesStore.Presentation.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityApplicationContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityApplicationContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<IdentityApplicationContext>();
            });
        }
    }
}