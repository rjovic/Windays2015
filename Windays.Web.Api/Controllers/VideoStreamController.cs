using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Windays.Web.Api.Infrastructure;

namespace Windays.Web.Api.Controllers
{
    [RoutePrefix("api/video")]
    public class VideoStreamController : ApiController
    {
        [Route("stream/{ext}/{filename}")]
        public HttpResponseMessage Get(string filename, string ext)
        {
            var video = new VideoStream(filename, ext);

            var response = Request.CreateResponse();
            response.Content = new PushStreamContent((Action<Stream, HttpContent, TransportContext>)video.WriteToStream, new MediaTypeHeaderValue("video/" + ext));

            return response;
        }

        [HttpPost]
        [Route("upload/browser")]
        public async Task<HttpResponseMessage> UploadFilesFromBrowser()
        {
            if (Request.Content.IsMimeMultipartContent())
            {
                string path = HttpContext.Current.Server.MapPath("~");               
                string imagePath = Path.Combine(path, @"Files\");

                var streamProvider = new MultipartFormDataStreamProvider(imagePath);
                await Request.Content.ReadAsMultipartAsync(streamProvider);

                foreach (var file in streamProvider.FileData)
                {
                    string newFileName = Path.Combine(imagePath, Guid.NewGuid().ToString() + ".jpg");
                    File.Move(file.LocalFileName, newFileName);                    
                }

                var response = Request.CreateResponse(HttpStatusCode.Accepted, "Good work, sir!");
                return response;

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable);
            }
        }
    }
}
