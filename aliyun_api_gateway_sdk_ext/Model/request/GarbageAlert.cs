/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：垃圾报警实体类
*│　作   者：week
*│　版   本：1.0
*│　创建时间：2019-03-01 15:20:26
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: aliyun_api_gateway_sdk_ext.Model.request
*│　类   名：GarbageAlert
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliyun_api_gateway_sdk_ext.Model.request
{
    public class GarbageAlert
    {
        /// <summary>
        /// 报警内容
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 报警来源
        /// </summary>
        public string source { get; set; }
    }
}
