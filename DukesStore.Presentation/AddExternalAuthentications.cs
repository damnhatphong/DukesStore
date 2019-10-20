using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DukesStore.Presentation
{
    public static class AddExternalAuthentications
    {
        public static AuthenticationBuilder AddExternalAuthenticationServices(this AuthenticationBuilder builder, IConfiguration Configuration)
        {
            builder.AddGoogleAuthentication(Configuration);
            builder.AddFacebookAuthentication(Configuration);
            return builder;
        }

        public static AuthenticationBuilder AddGoogleAuthentication(this AuthenticationBuilder builder, IConfiguration Configuration)
        {
            builder.AddGoogle(googleOptions =>
            {
                IConfigurationSection googleAuthNSection =
                    Configuration.GetSection("Authentication:Google");
                googleOptions.ClientId = googleAuthNSection["ClientId"];
                googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];
            });
            return builder;
        }


        public static AuthenticationBuilder AddFacebookAuthentication(this AuthenticationBuilder builder, IConfiguration Configuration)
        {
            builder.AddFacebook(facebookOptions =>
            {
                IConfigurationSection facebookAuthNSection =
                    Configuration.GetSection("Authentication:Facebook");
                facebookOptions.AppId = facebookAuthNSection["AppId"];
                facebookOptions.AppSecret = facebookAuthNSection["AppSecret"];
            });
            return builder;
        }

    }
}
