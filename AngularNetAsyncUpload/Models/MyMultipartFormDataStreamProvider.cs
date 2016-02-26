using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace AngularNetAsyncUpload.Models
{
    public class MyMultipartFormDataStreamProvider : MultipartFormDataStreamProvider
    {
        public MyMultipartFormDataStreamProvider(string rootPath) : base(rootPath)
        {

        }

        public override string GetLocalFileName(HttpContentHeaders headers)
        {
            var fname = base.GetLocalFileName(headers);
            return headers.ContentDisposition.FileName.TrimStart('"').TrimEnd('"');
        }
    }
}