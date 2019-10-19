using Microsoft.AspNetCore.Builder;

namespace DukesStore.Presentation
{
    public static class DukesStoreRouteExtensions
    {
        public static void AddDukesStoreRoute(this IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Products}/{action=Index}/{id?}");
            });
        }
    }
}
