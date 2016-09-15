using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace hwnn.Controllers
{
    //[Route("processing")]
    public class TempController : Controller
    {
        // GET: /<controller>/
        //[Route("fire")]
        //[Route("")]
        public string Display()
        {
            return "Temp Controller / Display called";
        }
    }
}
