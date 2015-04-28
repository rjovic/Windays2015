using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Windays.Web.Api.Infrastructure.Results
{
    public class ModelWithEtagResponse : IHttpActionResult
    {
        object _model;
        HttpRequestMessage _request;

        public ModelWithEtagResponse(object model, HttpRequestMessage request)
        {
            _model = model;
            _request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(System.Threading.CancellationToken cancellationToken)
        {
            HttpResponseMessage response;

            if (GetEtag() == _model.GetHashCode().ToString())
            {
                response = _request.CreateResponse(HttpStatusCode.NotModified);
            }
            else
            {
                response = _request.CreateResponse(HttpStatusCode.OK, _model);
                SetEtag(response, _model.GetHashCode().ToString());
            }

            return Task.FromResult(response);
        }

        private string GetEtag()
        {
            var etag = _request.Headers.IfNoneMatch.FirstOrDefault();
            string etagValue;

            if (etag != null)
            {
                etagValue = etag.ToString().Replace(@"""", "");
            }
            else
            {
                etagValue = null;
            }

            return etagValue;
        }

        private void SetEtag(HttpResponseMessage response, string value)
        {
            response.Headers.ETag = new EntityTagHeaderValue(string.Format(@"""{0}""", value));
        }
    }
}