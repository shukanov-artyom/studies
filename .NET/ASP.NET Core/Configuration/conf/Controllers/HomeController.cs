using System;
using conf.Configuration.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace conf.Controllers
{
    public class HomeController : Controller
    {
        private BusinessRulesOptions options;

        public HomeController(IOptions<BusinessRulesOptions> options)
        {
            this.options = options.Value;
        }

        public string Index()
        {
            return $"Options passed: AutoReg {options.AutomaticRegisterVehicles}, CanDelete {options.UsersCanDeleteVehicles}.";
        }
    }
}
