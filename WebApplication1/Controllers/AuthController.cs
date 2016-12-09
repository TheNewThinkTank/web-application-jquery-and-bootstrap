using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }

        public ActionResult Login()
        {
            //return Content("Login!");
            return View(new AuthLogin
                {
                    //Test = "This is my test value set in my controller!"
                });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            //return Content("Hey there, " + form.Username);
            //form.Test = "This is my test value set in my post action!";
            //return View(form);

            if (!ModelState.IsValid)
                return View(form);

            FormsAuthentication.SetAuthCookie(form.Username, true);

            //return Content("The form is valid");

            //if (form.Username != "rainbow dash")
            //{
            //    ModelState.AddModelError("Username", "Username or password isn't 20% cooler.");
            //    return View(form);
            //}

            if (!string.IsNullOrWhiteSpace(returnUrl))
                return Redirect(returnUrl);

            return RedirectToRoute("home");

        }





    }
}