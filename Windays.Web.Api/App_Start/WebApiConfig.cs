using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Microsoft.Practices.Unity;
using Windays.Web.Api.Data;
using Windays.Web.Api.Infrastructure.MessageHandlers;
using System.Net.Http.Formatting;
using Windays.Web.Api.Infrastructure.Formatters;
using System.Web.Http.ExceptionHandling;
using Windays.Web.Api.Infrastructure.Services;

namespace Windays.Web.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            // config.SuppressDefaultHostAuthentication();            

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Our IoC resolve settings
            var container = new UnityContainer();
            container.RegisterType<IPersonRepository, PersonRepository>(new HierarchicalLifetimeManager());

            config.DependencyResolver = new UnityResolver(container);

            // Here we define our own message handlers
            config.MessageHandlers.Add(new MessageLogHandler());

            // Here we define BSON and our own formatters  
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters.Add(new BsonMediaTypeFormatter());
            config.Formatters.Add(new CsvMediaTypeFormatter());

            //Here we add or replace out of the box services
            config.Services.Add(typeof(IExceptionLogger), new Log4NetExceptionLogger());
            config.Services.Replace(typeof(IExceptionHandler), new CustomExceptionHandler());
        }
    }
}
