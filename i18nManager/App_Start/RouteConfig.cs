using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace i18nManager
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            //// Resx Routes
            //routes.MapRoute(
            //    name: "ResxList",
            //    url: "Project/Resx/{projectId}",
            //    defaults: new { controller = "Resx", action = "ResourceStrings", projectId = 1 }
            //);

            routes.MapRoute(
                name: "Resx new route",
                url: "Project/Resx/{action}/{projectId}",
                defaults: new { controller = "Resx" }
                //defaults: new { controller = "Resx", action = "ResourceStrings", projectId = 1 }
            );


            //routes.MapRoute(
            //    name: "Resx Routes",
            //    url: "Project/Resx/{action}/{projectId}/{languageId}",
            //    defaults: new { controller = "Resx", action = "List", projectId = 1, languageId = 1 }
            //);




            // Lanaguage Routes
            routes.MapRoute(
                name: "LanguageList",
                url: "Project/Language/{projectId}",
                defaults: new { controller = "Language", action = "List", projectId = 1 }
            );

            routes.MapRoute(
                name: "Language Routes",
                url: "Project/Language/{action}/{projectId}/{languageId}",
                defaults: new { controller = "Language", action = "List", projectId = 1, languageId = UrlParameter.Optional }
            );




            // Default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Project", action = "List", id = UrlParameter.Optional }
            );



        }
    }
}