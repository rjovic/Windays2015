using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Windays.Web.Api.Data;

namespace Windays.Web.Api.Infrastructure.Results
{
    public class ExceptionResponse : IHttpActionResult
    {
        private Exception _exception;
        private HttpRequestMessage _request;

        public ExceptionResponse(Exception exception, HttpRequestMessage request)
        {
            _exception = exception;
            _request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute());
        }

        private HttpResponseMessage Execute()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            response.RequestMessage = _request;

            if (_exception is PersonNotFoundException)
            {
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
                response.Content = new StringContent("Entity not found");
                response.ReasonPhrase = "Sorry, not found!";
            }
            else
            {
                response.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                response.Content = new StringContent("You found out my weak spot :(");
                response.ReasonPhrase = "I'm ashame!";
            }

            return response;
        }
    }
}