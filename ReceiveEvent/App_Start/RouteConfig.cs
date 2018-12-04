using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ReceiveEvent {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            /*routes.MapRoute(
                name: "Get",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Event", action = "Get", id = UrlParameter.Optional },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
            );

            routes.MapRoute(
                name: "Post",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Event", action = "Post", id = UrlParameter.Optional },
                constraints: new {httpMethod = new HttpMethodConstraint("POST")}
            );

            routes.MapRoute(
                name: "API Page",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "EventUI", action = "Index", id = UrlParameter.Optional }
            );*/
        }
    }
}
