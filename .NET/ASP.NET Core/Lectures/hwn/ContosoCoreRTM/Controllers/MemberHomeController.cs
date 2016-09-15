using System;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace hw_.Controllers
{
    //[Route("Members")]
    //[Route("[controller]/[action]")]
    //[Route("[controller]/[action]/{id}")]
    public class MemberHomeController : Controller
    {
        //[Route("Index")]
        //[Route("")]
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
