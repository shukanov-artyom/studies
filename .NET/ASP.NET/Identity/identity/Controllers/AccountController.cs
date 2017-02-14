using System;
using System.Data.Entity.Core;
using System.Threading.Tasks;
using System.Web.Mvc;
using identity.Infrastructure;
using identity.Models;
using Microsoft.AspNet.Identity;

namespace identity.Controllers
{
    public class AccountController : ApplicationController
    {
        private readonly ApplicationUserManager userManager;

        public AccountController(ApplicationUserManager userManager)
        {
            if (userManager == null)
            {
                throw new ArgumentNullException("userManager");
            }
            this.userManager = userManager;
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Delete(DeleteAccountModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (model.Email.ToLower().Equals(CurrentUser.Email.ToLower()))
            {
                ApplicationUser user = await userManager.FindByNameAsync(CurrentUser.Email);
                if (user == null)
                {
                    throw new ObjectNotFoundException();
                }
                var result = await userManager.DeleteAsync(user);
                if (result == IdentityResult.Success)
                {
                    return RedirectToAction("LogOut", "Auth");
                }
            }
            return View();
        }
    }
}