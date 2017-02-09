using System;
using System.Security.Claims;
using System.Web.Mvc;
using identity.Infrastructure;

namespace identity.Views
{
    public abstract class ApplicationViewPage<TModel> : WebViewPage<TModel>
    {
        protected ApplicationPrincipal CurrentUser
        {
            get
            {
                return new ApplicationPrincipal(User as ClaimsPrincipal);
            }
        }
    }

    public abstract class ApplicationViewPage : ApplicationViewPage<dynamic>
    {
        // intentionally left blank
    }
}