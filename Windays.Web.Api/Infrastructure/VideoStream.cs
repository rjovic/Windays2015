using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Windays.Web.Api.Infrastructure
{
    public class VideoStream
    {
        private readonly string _filename;
        private static readonly ILog _log = LogManager.GetLogger(typeof(VideoStream));

        public VideoStream(string filename, string ext)
        {
            // TODO : replace this path with your own path to the folder where you have video files
            // I suggest to use WebM format for streaming video because every browser have out of the box support for it
            _filename = @"C:\Users\Renato\Desktop\" + filename + "." + ext;
        }

        public async void WriteToStream(Stream outputStream, HttpContent content, TransportContext context)
        {
            try
            {
                var buffer = new byte[65536];

                using (var video = File.Open(_filename, FileMode.Open, FileAccess.Read))
                {
                    var length = (int)video.Length;
                    var bytesRead = 1;

                    while (length > 0 && bytesRead > 0)
                    {
                        bytesRead = video.Read(buffer, 0, Math.Min(length, buffer.Length));
                        await outputStream.WriteAsync(buffer, 0, bytesRead);
                        length -= bytesRead;                        
                    }
                }
            }
            catch (HttpException ex)
            {
                _log.Error(ex.Message, ex);
            }
            finally
            {
                outputStream.Close();
            }
        }
    }
}