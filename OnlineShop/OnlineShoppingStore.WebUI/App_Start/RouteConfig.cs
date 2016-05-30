using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            "Default",                                              // Route name 
            "{controller}/{action}/{id}",                           // URL with parameters 
            new { controller = "Account", action = "Login", id = "" }  // Parameter defaults
        );
            routes.MapRoute(null, "",
                new
                {
                    controller = "Product",
                    action = "List",
                    category = (string) null,
                    page = 1
                });

            routes.MapRoute(null, "Page{page}",
                new
                {
                    controller = "Product",
                    action = "List",
                    category =
                        (string) null
                },
                new {page = @"\d+"});

            routes.MapRoute(null,
                "{category}",
                new {controller = "Product", action = "List", page = 1}
                );

            routes.MapRoute(null,
                "{category}/Page{page}",
                new {controller = "Product", action = "List"},
                new {page = @"\d+"}
                );
           routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
