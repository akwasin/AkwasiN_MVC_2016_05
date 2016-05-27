using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AkwasiN_MVC_2016_05
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Stores", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Sprite",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Sprite", action = "Index", id = UrlParameter.Optional }
            );

           
        }
    }
}
