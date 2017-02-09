using System;
using System.Web.Mvc;
using identity.Infrastructure;

namespace identity.Controllers
{
    /// <summary>
    /// Base class for controllers exposing strongly-typed 
    /// claims principal (wrapped into ApplicationPrincipal)
    /// </summary>
    public class ApplicationController : Controller
    {
        public ApplicationPrincipal CurrentUser
        {
            get
            {
                return new ApplicationPrincipal(User as ApplicationPrincipal);
            }
        }
    }
}