using System;
using identity.Controllers;
using identity.Infrastructure;
using identity.Persistency;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace identity
{
    /// <summary>
    /// Class will be automatically found and used by OWIN framework.
    /// </summary>
    public class Startup
    {
        public static Func<UserManager<ApplicationUser>> UserManagerFactory { get; set; }

        public void Configuration(IAppBuilder app)
        {
            // let's use cookie authentication!
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                // identify the cookie
                AuthenticationType = AuthenticationData.CookieName,
                // where to redirect for login? (/controller/action)
                LoginPath = new PathString("/auth/login")
            });

            UserManagerFactory = () =>
            {
                var userManager = new UserManager<ApplicationUser>(
                    new UserStore<ApplicationUser>(new ApplicationDbContext()));

                userManager.ClaimsIdentityFactory = new ApplicationClaimsIdentityFactory();

                userManager.UserValidator = new UserValidator<ApplicationUser>(userManager)
                {
                    AllowOnlyAlphanumericUserNames = false
                };
                return userManager;
            };
        }
    }
}