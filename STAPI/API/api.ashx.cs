using aliyun_api_gateway_sdk_ext.Sign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STAPI.API
{
    /// <summary>
    /// api 的摘要说明
    /// </summary>
    public class api : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (isSign.Sign(context)) {
                context.Response.ContentType = "text/plain";
                context.Response.Write("Hello World");
            }
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}