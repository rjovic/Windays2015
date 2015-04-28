using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;
using Windays.Web.Api.Infrastructure.Results;

namespace Windays.Web.Api.Infrastructure.Services
{
    public class CustomExceptionHandler : ExceptionHandler
    {
        public override bool ShouldHandle(ExceptionHandlerContext context)
        {
            return true;
        }

        public override void Handle(ExceptionHandlerContext context)
        {
            context.Result = new ExceptionResponse(context.Exception, context.Request);
        }
    }
}