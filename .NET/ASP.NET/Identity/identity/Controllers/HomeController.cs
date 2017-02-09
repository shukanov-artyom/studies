using System;
using System.Web.Mvc;

namespace identity.Controllers
{
    public class HomeController : ApplicationController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}