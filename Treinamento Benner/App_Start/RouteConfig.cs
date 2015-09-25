using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Treinamento_Benner
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Historico",
                url: "Arquivo/{data}",
                defaults: new { controller = "Historico", Action = "Arquivo" });


            routes.MapRoute(
                name: "Default",//route name
                url: "{controller}/{action}/{id}",//url with parameters
                defaults://parameter defaults
                    new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            
        }
    }
}