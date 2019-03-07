using aliyun_api_gateway_sdk.Util;
using aliyun_api_gateway_sdk_ext.DAL;
using aliyun_api_gateway_sdk_ext.Model;
using aliyun_api_gateway_sdk_ext.Utils;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;

namespace aliyun_api_gateway_sdk_ext.Sign
{
    public class isSign
    {
        private static  String appKey = "";
        private static  String appSecret = "";

        /**
         *找到key和秘钥
         **/
        public static int getKey(int tenid)
        {
            ST_Api_token tenancy = new ST_tenancyDAL().GetAppkey(tenid);
            if (tenancy != null)
            {
                appKey = tenancy.appKey;
                appSecret = tenancy.appSecret;
                return 200;
            }
            else
            {
                return 405;//暂无秘钥对配置
            }

        }
        public static int Sign(System.Web.HttpContext context,int tenid)
        {

            int code = getKey(tenid);
            if (code != 200)
            {
                return code;
            }
            Dictionary<String, String> headers = new Dictionary<string, string>();
            Dictionary<String, String> querys = new Dictionary<string, string>();
            Dictionary<String, String> bodys = new Dictionary<string, string>();
            List<String> signHeader = new List<String>();
            string returnstr = "false";
            string signH = context.Request.Headers["X-Ca-Signature-Headers"];
            string path = context.Request.PathInfo;
            string method = context.Request.HttpMethod;
            string host = context.Request.Headers["Host"];
            string Signature = context.Request.Headers["X-Ca-Signature"];
            HttpRequest request = context.Request;
            Stream stream = request.InputStream;
            string json = string.Empty;
            string responseJson = string.Empty;
            if (stream.Length != 0)
            {
                StreamReader streamReader = new StreamReader(stream);
                json = streamReader.ReadToEnd();
            }
            foreach (string key in request.Form)
            {
                bodys.Add(key, request.Form[key]);
            }
            #region
            //headers.Add(HttpHeader.HTTP_HEADER_CONTENT_TYPE, context.Request.Headers[HttpHeader.HTTP_HEADER_CONTENT_TYPE]);
            ////设定Accept，根据服务器端接受的值来设置
            //headers.Add(HttpHeader.HTTP_HEADER_ACCEPT, context.Request.Headers[HttpHeader.HTTP_HEADER_ACCEPT]);
            ////注意：如果有非Form形式数据(body中只有value，没有key)；如果body中是key/value形式数据，不要指定此行
            //headers.Add(HttpHeader.HTTP_HEADER_CONTENT_MD5, context.Request.Headers[HttpHeader.HTTP_HEADER_CONTENT_MD5]);
            //signHeader.Add(SystemHeader.X_CA_TIMESTAMP);
            #endregion
            foreach (String key in context.Request.Headers)
            {
                if (key != "X-Ca-Signature-Headers" && key != "X-Natapp-Ip" && key != "X-Real-Ip" && key != "Host" && key != "Connection" && key != "Content-Length" && key != "X-Ca-Signature")
                {
                    headers.Add(key, context.Request.Headers[key]);
                }
            }
            if (signH != null)
            {
                foreach (String key in signH.Split(','))
                {
                    signHeader.Add(key);

                }
            }
            foreach (String key in context.Request.QueryString)
            {
                querys.Add(key, context.Request.QueryString[key]);

            }
            string Signature_now = SignUtil.Sign(path, method, appSecret, headers, querys, bodys, signHeader);
            
            if ( Signature_now == Signature)
            {
                return 200;//验签通过
            }
            return 401;//验签失败
        }
    }
}