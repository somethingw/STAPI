using aliyun_api_gateway_sdk_ext.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STAPI.API
{
    /// <summary>
    /// test 的摘要说明
    /// </summary>
    public class test : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            TenacyDbContext tenacyDbContext = new TenacyDbContext(43);
            context.Response.Write("Hello World");
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