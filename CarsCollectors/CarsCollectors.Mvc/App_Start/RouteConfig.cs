﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarsCollectors.Mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "DefaultApi",
                url: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
