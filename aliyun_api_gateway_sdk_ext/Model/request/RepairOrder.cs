/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：维修单实体类
*│　作   者：week
*│　版   本：1.0
*│　创建时间：2019-03-01 15:25:06
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: aliyun_api_gateway_sdk_ext.Model.request
*│　类   名：RepairOrder
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliyun_api_gateway_sdk_ext.Model.request
{
    public class RepairOrder
    {
        /// <summary>
        /// 上海市静安区
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int partCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sourceCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int itemCode { get; set; }
        /// <summary>
        /// week李
        /// </summary>
        public string contacts { get; set; }
        /// <summary>
        /// 门灯坏了
        /// </summary>
        public string detailed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int appointTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string appointDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string phone { get; set; }
    }
}
