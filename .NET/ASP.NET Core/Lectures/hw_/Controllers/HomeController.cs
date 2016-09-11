using System;
using hw_.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace hw_.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var contact = new Contact()
            {
                FirstName = "Artyom",
                LastName = "Shukanov"
            };
            return View(contact);
        }
    }
}
