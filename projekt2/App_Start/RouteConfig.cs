using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace projekt2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
         

            routes.MapRoute(
                name: "SzczegolySamochod",
                url: "samochod-{id}",
                defaults: new {controller = "sklep",action="szczegoly"}            
            );

            routes.MapRoute(
                name: "SamochodLista",
                url: "model/{nazwa}",
                defaults: new { controller = "sklep", action = "lista" },
                constraints: new { nazwa=@"[\w]+" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
