﻿using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MascotasWebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings
               .Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept",
                           "text/html",
                           StringComparison.InvariantCultureIgnoreCase,
                           true,
                           "application/json")
               );
        }
    }
}
