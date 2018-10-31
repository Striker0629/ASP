using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Product_list",
                url: "List",
                defaults: new { controller = "Product", action = "List", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Product",
                url: "List/Product/{id}",
                defaults: new { controller = "Product", action = "Product",id=UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        //    routes.MapRoute(
        //        name:"Product",
        //        url:"{controller}/{action}/{id}",
                
        //}
    }
}
