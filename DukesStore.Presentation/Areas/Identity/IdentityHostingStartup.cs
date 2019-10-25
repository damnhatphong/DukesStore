using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(DukesStore.Presentation.Areas.Identity.IdentityHostingStartup))]
namespace DukesStore.Presentation.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}