/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：封装对租户的基本操作
*│　作   者：week
*│　版   本：1.0
*│　创建时间：2019-02-27 14:08:23
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: aliyun_api_gateway_sdk_ext.DAL
*│　类   名：ST_tenancyDAL
*└──────────────────────────────────────────────────────────────┘
*/
using aliyun_api_gateway_sdk_ext.Model;
using aliyun_api_gateway_sdk_ext.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliyun_api_gateway_sdk_ext.DAL
{
    public class ST_tenancyDAL:DbContext
    {
        public ST_Api_token GetAppkey(int ten_ID)
        {
            return Db.Queryable<ST_Api_token>().InSingle(ten_ID);
        }
    }
}
