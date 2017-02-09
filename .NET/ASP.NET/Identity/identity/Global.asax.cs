using System;
using System.Web.Mvc;
using System.Web.Routing;

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
        }
    }
}
