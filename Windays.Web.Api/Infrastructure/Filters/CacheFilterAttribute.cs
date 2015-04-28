using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http.Filters;

namespace Windays.Web.Api.Infrastructure.Filters
{
    public class CacheFilterAttribute : ActionFilterAttribute
    {
        public int MaxAge { get; set; }

        public CacheFilterAttribute(int maxAge)
        {
            MaxAge = maxAge;
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            // if some exception happened before in pipeline, response will be null
            if (actionExecutedContext.Response == null)
            {
                return;
            }

            HttpStatusCode statusCode = actionExecutedContext.Response.StatusCode;
            if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.NotModified)
            {
                var response = actionExecutedContext.Response;

                var cacheControl = new CacheControlHeaderValue();
                cacheControl.MaxAge = TimeSpan.FromSeconds(MaxAge);

                response.Headers.CacheControl = cacheControl;
            }

            base.OnActionExecuted(actionExecutedContext);
        }
    }
}