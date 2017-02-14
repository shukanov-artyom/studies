using System;
using System.Reflection;
using Autofac;
using Autofac.Integration.Mvc;
using identity.Controllers;
using identity.Infrastructure;
using identity.Persistency;
using Module = Autofac.Module;

namespace identity.DependencyInjection
{
    /// <summary>
    /// Default Autofac module registering all requred dependencies.
    /// </summary>
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // registering controllers
            builder.RegisterControllers(typeof(HomeController).Assembly);

            // registering data context (Transient Scope)
            builder.RegisterType<ApplicationDbContext>().AsSelf().InstancePerDependency();

            // registering Identity custom UserManager factory 
            // to get new ApplicationUserManager
            builder.Register(c => ApplicationUserManagerFactory.Create());
        }
    }
}