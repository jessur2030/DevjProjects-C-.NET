﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JRXCONSTRUCTIONLLCWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "Home", new { controller = "Home", action = "Index" });
            routes.MapRoute("About", "About", new { controller = "Home", action = "About" });
            routes.MapRoute("Contact", "Contact", new { controller = "Home", action = "Contact" });
            routes.MapRoute("Projects", "Projects", new { controller = "Home", action = "Projects" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
