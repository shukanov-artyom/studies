using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IdentCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger; 

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
