using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Windays.Web.Api.Infrastructure.MessageHandlers
{
    public class MessageLogHandler : DelegatingHandler
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(MessageLogHandler));

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Log the request information
            LogRequest(request);

            // Execute the request
            var response = await base.SendAsync(request, cancellationToken);

            // Log the response information
            LogResponse(response);

            return response;
        }

        private async void LogRequest(HttpRequestMessage request)
        {
            _log.InfoFormat("REQUEST {0} - {1}, {2}", request.GetCorrelationId(), request.Method, request.RequestUri);

            if (request.Content != null && _log.IsDebugEnabled)
            {
                var result = await request.Content.ReadAsByteArrayAsync();
                var content = Encoding.UTF8.GetString(result);

                _log.DebugFormat("REQUEST {0} - {1}", request.GetCorrelationId(), String.IsNullOrEmpty(content) ? "NO DATA SENT" : content);
            }
        }

        private async void LogResponse(HttpResponseMessage response)
        {
            _log.InfoFormat("RESPONSE {0} - {1}, {2} - {3} {4}", response.RequestMessage.GetCorrelationId(), response.RequestMessage.Method, response.RequestMessage.RequestUri, response.StatusCode, response.ReasonPhrase);

            if (response.Content != null && _log.IsDebugEnabled)
            {
                var result = await response.Content.ReadAsByteArrayAsync();
                var content = Encoding.UTF8.GetString(result);

                _log.DebugFormat("RESPONSE {0} - {1}", response.RequestMessage.GetCorrelationId(), content);                 
            }
        }
    }
}