/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：报警报修实体类
*│　作   者：week
*│　版   本：1.0
*│　创建时间：2019-03-01 15:21:48
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: aliyun_api_gateway_sdk_ext.Model.request
*│　类   名：FireControlAlert
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliyun_api_gateway_sdk_ext.Model.request
{
    public class FireControlAlert
    {

        /// <summary>
        /// 状态码
        /// </summary>
        public string statusCode { get; set; }
        /// <summary>
        /// 系统类型
        /// </summary>
        public string sysType { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public long time { get; set; }
        /// <summary>
        /// 状态内容，解析状态码, 同时可包括其它内容有：延时、反馈、启动、监管、屏蔽、故障、火警、测试
        /// </summary>
        public List<string> status { get; set; }
        /// <summary>
        /// 部件类型
        /// </summary>
        public string unitType { get; set; }
        /// <summary>
        /// 描述内容
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 区号
        /// </summary>
        public string zoneCode { get; set; }
        /// <summary>
        /// 系统地址
        /// </summary>
        public string sysAddr { get; set; }
        /// <summary>
        /// 位号
        /// </summary>
        public string unitCode { get; set; }
    }
}
