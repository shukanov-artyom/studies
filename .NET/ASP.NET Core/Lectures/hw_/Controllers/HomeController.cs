using System;
using hw_.Models;
using hw_.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace hw_.Controllers
{
    public class HomeController : Controller
    {
        //[HttpGet]
        public IActionResult IndexWithForm()
        {
            return View("IndexWithForm");
        }

        //[HttpPost]   
        public IActionResult Index([FromQuery] Contact contact)
        {
            //var contact = new Contact() // model class!
            //{
            //    FirstName = "Artyom",
            //    LastName = "Shukanov",
            //    Id = 1
            //};

            var customer = new Customer()
            {
                Id = 2,
                CustomerName = "Company"
            };

            var vm = new HomeIndexViewModel()
            {
                Contact = contact,
                Customer = customer
            };

            return View(vm);
        }

        public IActionResult DownloadData()
        {
            return File("/DownloadData/TestData.txt", "text/plain", "TooSexy.txt");
        }
    }
}
