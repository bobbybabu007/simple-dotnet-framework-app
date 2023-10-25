using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAppl5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Contact",
                url: "contact",
                defaults: new { controller = "Home", action = "Contact" }
            );
            routes.MapRoute(
                name: "Docker",
                url: "docker",
                defaults: new { controller = "Home", action = "Docker" }
            );
            routes.MapRoute(
                name: "Kubernetes",
                url: "kubernetes",
                defaults: new { controller = "Home", action = "Kubernetes" }
            );
            routes.MapRoute(
                name: "Database",
                url: "database",
                defaults: new { controller = "Home", action = "Database" }
            );
            routes.MapRoute(
                name: "Query",
                url: "query",
                defaults: new { controller = "Query", action = "Index" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
