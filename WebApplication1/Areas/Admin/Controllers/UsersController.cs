using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate.Linq;
using WebApplication1.Areas.Admin.ViewModels;
using WebApplication1.Infrastructure;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("users")]
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return View(new UsersIndex
                {
                    Users = Database.Session.Query<User>().ToList()
                });
        }
    }
}