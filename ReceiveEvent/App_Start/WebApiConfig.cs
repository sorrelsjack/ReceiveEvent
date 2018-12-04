﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ReceiveEvent {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("html/text"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Get",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "Event", action = "Get", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Post",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { controller = "Event", action = "Post" }
            );

            config.Routes.MapHttpRoute(
                name: "API Page",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "EventUI", action = "Index", id = RouteParameter.Optional }
            );
        }
    }
}
