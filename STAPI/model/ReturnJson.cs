/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：统一的返回json
*│　作   者：week
*│　版   本：1.0
*│　创建时间：2019-03-01 13:48:47
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: STAPI.model
*│　类   名：ReturnJson
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STAPI.model
{
    public class ReturnJson
    {

        /// <summary>
        /// 在构造函数里赋初值
        /// </summary>
        public ReturnJson()
        {
            id = Guid.NewGuid().ToString();
            code = 400;
            message = "request error";

        }
        /// <summary>
        /// 为该请求生成的唯一标识符。
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 通用错误码。
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 调用结果的英文描述。
        /// </summary>
        public string message { get; set; }
    }
}