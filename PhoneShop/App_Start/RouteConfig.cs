﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PhoneShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home_62132473", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "PhoneShop.Controllers" }
            );

            routes.MapRoute(
                name: "Product",
                url: "Home/Product/{id}",
                defaults: new { controller = "Home_62132473", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "PhoneShop.Controllers" }
            );

          
        }
    }
}
