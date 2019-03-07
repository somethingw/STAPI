/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：请求的根
*│　作   者：week
*│　版   本：1.0
*│　创建时间：2019-02-27 16:33:33
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: aliyun_api_gateway_sdk_ext.Model.request
*│　类   名：Root
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliyun_api_gateway_sdk_ext.Model.request
{
    public class Root
    {
        /// <summary>
        /// 请求 ID。由请求方申请生成，代表此次请求的唯一标识。
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 协议版本号。目前取值为1.0。
        /// </summary>
        public string version { get; set; }
        /// <summary>
        /// 租户id
        /// </summary>
        public int tenantId { get; set; }
        /// <summary>
        /// 要调用的api名称
        /// </summary>
        public string apiName { get; set; }
        /// <summary>
        /// api版本号
        /// </summary>
        public Request request { get; set; }
        
       }

}
