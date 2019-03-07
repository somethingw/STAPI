/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：真正用来存放数据包的类
*│　作   者：week
*│　版   本：1.0
*│　创建时间：2019-03-01 15:13:29
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: aliyun_api_gateway_sdk_ext.Model.request
*│　类   名：APIRequest
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliyun_api_gateway_sdk_ext.Model.request
{
    public class APIRequest:Root
    {
        public object @params{get;set;}
    }
}
