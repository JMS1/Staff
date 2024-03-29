﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;



using System.Web.Cors;
using System.Web.Http.Cors;
namespace StaffDirectory
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var policy = new EnableCorsAttribute("*", "*", "*");
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.EnableCors(policy);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
