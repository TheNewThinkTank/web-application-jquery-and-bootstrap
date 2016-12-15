using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Infrastructure;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("posts")]
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            //return View();
            return Content("Hello, World!");
        }
    }
}