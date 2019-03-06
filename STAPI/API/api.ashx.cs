using aliyun_api_gateway_sdk_ext.DAL;
using aliyun_api_gateway_sdk_ext.Model.request;
using aliyun_api_gateway_sdk_ext.Sign;
using Newtonsoft.Json;
using STAPI.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
            {407,"Non-existent API"},
            {404,"service not found"},{429,"too many requests"},{460,"request parameter error"},{500,"service error"},{503,"service not available"}
        };


        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            Stream stream = context.Request.InputStream;
            string json = string.Empty;//得到json包
            ReturnJson returnJson = new ReturnJson();
            Root root=new Root();
            if (stream.Length != 0)
            {
                StreamReader streamReader = new StreamReader(stream,Encoding.GetEncoding("utf-8"));
                json = streamReader.ReadToEnd();
            }
            try
            {
                root = JsonConvert.DeserializeObject<Root>(json);
            }
            catch
            {
                returnJson.code = 460;
                returnJson.message = code[460];
                context.Response.Write(JsonConvert.SerializeObject(returnJson));
            }
            int sign_code = isSign.Sign(context,root.tenantId);
            returnJson.code = sign_code;
            returnJson.message = code[sign_code];
            if (sign_code == 200)//验签通过，进行接口实际操作
            {
                APIRequest apiRequest = JsonConvert.DeserializeObject<APIRequest>(json);
                if (apiRequest.apiName == "setGarbageAlert")//垃圾报警
                {
                    GarbageAlert garbageAlert = new GarbageAlert();
                    try
                    {
                        garbageAlert = JsonConvert.DeserializeObject<GarbageAlert>(apiRequest.@params.ToString());
                        int res_code = new Alarm_RepairDAL(apiRequest.tenantId).setGarbageAlert(garbageAlert);
                        returnJson.code = res_code;
                        returnJson.message = code[res_code];
                    }
                    catch
                    {
                        returnJson.code = 400;
                        returnJson.message = code[400];
                        context.Response.Write(JsonConvert.SerializeObject(returnJson));
                    }
                   
                }
                else if (apiRequest.apiName== "setFireControlAlert")//消防报警
                {
                    FireControlAlert fireControlAlert = new FireControlAlert();
                    try
                    {
                        fireControlAlert = JsonConvert.DeserializeObject<FireControlAlert>(apiRequest.@params.ToString());
                        int res_code = new Alarm_RepairDAL(apiRequest.tenantId).setFireControlAlert(fireControlAlert);
                        returnJson.code = res_code;
                        returnJson.message = code[res_code];
                    }
                    catch
                    {
                        returnJson.code = 400;
                        returnJson.message = code[400];
                        context.Response.Write(JsonConvert.SerializeObject(returnJson));
                    }
                    
                   
                }
                else if (apiRequest.apiName == "setRepairOrder")//报修
                {
                    RepairOrder repairOrder = new RepairOrder();
                    try
                    {
                        repairOrder = JsonConvert.DeserializeObject<RepairOrder>(apiRequest.@params.ToString());
                        int res_code = new Alarm_RepairDAL(apiRequest.tenantId).setRepairOrder(repairOrder);
                        returnJson.code = res_code;
                        returnJson.message = code[res_code];
                    }
                    catch
                    {
                        returnJson.code = 400;
                        returnJson.message = code[400];
                        context.Response.Write(JsonConvert.SerializeObject(returnJson));
                    }
                    
                }
                else
                {
                    returnJson.code = 407;
                    returnJson.message = code[407];
                }

            }
            context.Response.Write(JsonConvert.SerializeObject(returnJson));


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