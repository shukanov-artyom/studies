using System;
using identity.Controllers;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace identity
{
    /// <summary>
    /// Class will be automatically found and used by OWIN framework.
    /// Resembles .NET Core middleware wireup on startup.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configures application to be used by our OWIN server.
        /// </summary>
        public void Configuration(IAppBuilder app)
        {
            // Wire up OWIN Cookie middleware for authentication
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                // identify the cookie
                AuthenticationType = AuthenticationData.CookieName,
                // where to redirect for login? (/controller/action)
                LoginPath = new PathString("/auth/login")
            });

            // Wire up CORS
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
        }
    }
}