using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IdentCore.Controllers
{
    public class LoggingTestController : Controller
    {
        private readonly ILogger logger;

        public LoggingTestController(ILogger<LoggingTestController> logger)
        {
            this.logger = logger;
        }

        public ActionResult GenerateInfoMessage()
        {
            logger.LogInformation("Some information logged from {controller} and {action}", 
                "LoggingTestController", 
                "GenerateInfoMessage");
            return RedirectToAction("Index", "Home");
        }

        public ActionResult GenerateWarnMessage()
        {
            logger.LogWarning("Some information logged from {controller} and {action}",
                "LoggingTestController",
                "GenerateWarnMessage");
            return RedirectToAction("Index", "Home");
        }

        public ActionResult GenerateErrorMessage()
        {
            logger.LogError("Some information logged from {controller} and {action}",
                "LoggingTestController",
                "GenerateErrorMessage");
            return RedirectToAction("Index", "Home");
        }
    }
}
