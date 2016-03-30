using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SGA
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index"}
            );

            routes.MapRoute(
               name: "Crud",
               url: "{controller}/crud/{user}",
               defaults: new { controller = "Home", action = "Crud", user = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Guardar",
               url: "{controller}/guardar/{user}",
               defaults: new { controller = "Home", action = "Guardar", user = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Ver",
                url: "{controller}/ver/{user}",
                defaults: new { controller = "Home", action = "Ver", user = UrlParameter.Optional }
            );

            

        }
    }
}
