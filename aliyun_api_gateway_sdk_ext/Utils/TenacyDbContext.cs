/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：用来连接租户数据库的封装类
*│　作   者：week
*│　版   本：1.0
*│　创建时间：2019-03-01 14:03:32
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: aliyun_api_gateway_sdk_ext.Utils
*│　类   名：TenacyDbContext
*└──────────────────────────────────────────────────────────────┘
*/
using aliyun_api_gateway_sdk_ext.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace aliyun_api_gateway_sdk_ext.Utils
{
    public class TenacyDbContext
    {
        public static readonly string connstr =
               WebConfigurationManager.ConnectionStrings["controlServer"].ConnectionString;  //连接字符串
        public static readonly string dbstr =
               WebConfigurationManager.ConnectionStrings["TenacyDb"].ConnectionString;  //租户连接字符串
        public TenacyDbContext(int ten_id)
        {
            //首先从主数据库获取信息
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = connstr,
                DbType = DbType.SqlServer,
                InitKeyType = InitKeyType.Attribute,//从特性读取主键和自增列信息
                IsAutoCloseConnection = true,//开启自动释放模式和EF原理一样我就不多解释了
            });
            List<ST_tenancy_dbinfo> dt = db.Ado.SqlQuery<ST_tenancy_dbinfo>(@"select b.* from ST_tenancy_to_db a left join ST_tenancy_dbinfo b on a.db_ID=b.ID left join ST_Api_token c on a.ten_ID=c.ten_ID
                                                      where c.ID=@id", new { id = ten_id });//更新成用appID来获取数据库信息
            if (dt.Count > 0)
            {
                string str = dbstr.Replace("$", dt[0].dbName);
                Db = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = str,
                    DbType = DbType.SqlServer,
                    InitKeyType = InitKeyType.Attribute,//从特性读取主键和自增列信息
                    IsAutoCloseConnection = true,//开启自动释放模式和EF原理一样我就不多解释了
                });
            }

        }
        public SqlSugarClient Db;//用来处理事务多表查询和复杂的操作
    }
}
