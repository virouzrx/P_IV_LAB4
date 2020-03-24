using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace P4_LAB4
{
    class FileDownloadingController:ApiController
    {
        [HttpGet]
        [Route("api/FileDownloading/download")]
        public HttpResponseMessage GetDate()
        {
            var result = new HttpResponseMessage(HttpStatusCode.OK);

            return result;
        }
    }
}
