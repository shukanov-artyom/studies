using System;
using System.Web.Mvc;

namespace identity
{
    /// <summary>
    /// Let's make actions decorated with [Authorize] by default.
    /// Ones who need unauthorized access will be explicitly whitelisted.
    /// </summary>
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());
        }
    }
}