using System;
using Autofac;
using identity.Controllers;
using identity.Infrastructure;
using identity.Persistency;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace identity.DependencyInjection
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // registering controllers
            builder.RegisterType<HomeController>().InstancePerRequest();
            builder.RegisterType<AuthController>().InstancePerRequest();

            // registering services and other dependencies
            builder.Register(c => CreateUserManagerFactory());
        }

        private UserManager<ApplicationUser> CreateUserManagerFactory()
        {
            var userManager = new UserManager<ApplicationUser>(
                    new UserStore<ApplicationUser>(new ApplicationDbContext()));
            userManager.ClaimsIdentityFactory = new ApplicationClaimsIdentityFactory();
            userManager.UserValidator = new UserValidator<ApplicationUser>(userManager)
            {
                AllowOnlyAlphanumericUserNames = false
            };
            return userManager;
        }
    }
}