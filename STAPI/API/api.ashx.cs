using aliyun_api_gateway_sdk_ext.Sign;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace STAPI.API
{
    /// <summary>
    /// api 的摘要说明
    /// </summary>
    public class api : IHttpHandler
    {
        //返回状态码对应说明
        private Dictionary<int, string> code = new Dictionary<int, string>
        {
            {200,"success"},{400,"request error"},{401,"request auth error"},{403,"request forbidden"},
            {404,"service not found"},{429,"too many requests"},{460,"request parameter error"},{500,"service error"},{503,"service not available"}
        };


        public void ProcessRequest(HttpContext context)
        {
            
            context.Response.ContentType = "text/plain";
            Stream stream = context.Request.InputStream;
            string json = string.Empty;//得到json包
            string responseJson = string.Empty;
            if (stream.Length != 0)
            {
                StreamReader streamReader = new StreamReader(stream);
                json = streamReader.ReadToEnd();
            }
            context.Response.Write(isSign.Sign(context));
            
            
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