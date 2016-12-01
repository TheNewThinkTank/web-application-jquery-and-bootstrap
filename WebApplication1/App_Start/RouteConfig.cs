using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication1.Controllers;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] {typeof(PostsController).Namespace};
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Login", "login", new {controller = "Auth", action = "Login"}, namespaces);

            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" }, namespaces);

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
