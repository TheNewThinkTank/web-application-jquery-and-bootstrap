using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            //return Content("<h1>HEY THERE!</h1>");
            return View();
        }
    }
}