using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace Windays.Web.Api.Infrastructure.Services
{
    public class Log4NetExceptionLogger : ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            var log = LogManager.GetLogger("ExceptionLogger");
            log.ErrorFormat("Unhandled exception {0} - {1} - {2}", context.Request.Method, context.Request.RequestUri, context.Exception);
        }
    }
}