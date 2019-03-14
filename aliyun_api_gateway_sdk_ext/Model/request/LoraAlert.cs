/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：
*│　作   者：week
*│　版   本：1.0
*│　创建时间：2019-03-14 11:07:47
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: aliyun_api_gateway_sdk_ext.Model.request
*│　类   名：LoraAlert
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliyun_api_gateway_sdk_ext.Model.request
{
    public class LoraAlert
    {
        /// <summary>
        /// 时间 yyyy-mm-dd hh:mm:ss
        /// </summary>
        public string time { get; set; }
        /// <summary>
        /// 告警1-产生0-消除 2 通知
        /// </summary>
        public int flag { get; set; }
        /// <summary>
        /// 告警描述
        /// </summary>
        public string alarmdesc { get; set; }
        /// <summary>
        /// 告警阈值
        /// </summary>
        public string alarm_th { get; set; }
        /// <summary>
        /// 唯一标识码
        /// </summary>
        public string deveui { get; set; }
        /// <summary>
        ///dealmsg
        /// </summary>
        public string dealmsg { get; set; }
        /// <summary>
        /// 告警等级1-4级
        /// </summary>
        public string alarmlevel { get; set; }
        /// <summary>
        /// 设备类型
        /// </summary>
        public string devtype { get; set; }
        /// <summary>
        /// 告警/通知类型",1-alert, 2-notify
        /// </summary>
        public int alarmtype { get; set; }
        /// <summary>
        /// 设备位置
        /// </summary>
        public string devicelocation { get; set; }
        /// <summary>
        /// 实际值
        /// </summary>
        public string datavalue { get; set; }
    }
}
