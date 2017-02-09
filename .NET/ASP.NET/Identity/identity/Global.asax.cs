using System;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using identity.DependencyInjection;

namespace identity
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // configuring global filters
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            // autofac
            // Creating a builder instance for a container 
            var builder = new ContainerBuilder();
            builder.RegisterModule<DefaultModule>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
