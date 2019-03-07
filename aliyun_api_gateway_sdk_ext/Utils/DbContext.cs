/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：封装的用于获取配置，连接数据库并返回对象的类
*│　作   者：week
*│　版   本：1.0
*│　创建时间：2019-02-27 13:59:47
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: aliyun_api_gateway_sdk_ext.Utils
*│　类   名：DbContext
*└──────────────────────────────────────────────────────────────┘
*/
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace aliyun_api_gateway_sdk_ext.Utils
{
    
    public class DbContext
    {
        public static readonly string connstr =
                WebConfigurationManager.ConnectionStrings["controlServer"].ConnectionString;  //连接字符串
        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = connstr,
                DbType = DbType.SqlServer,
                InitKeyType = InitKeyType.Attribute,//从特性读取主键和自增列信息
                IsAutoCloseConnection = true,//开启自动释放模式和EF原理一样我就不多解释了

            });
            //调试代码 用来打印SQL 
            //Db.Aop.OnLogExecuting = (sql, pars) =>
            //{
            //    Console.WriteLine(sql + "\r\n" +
            //        Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
            //    Console.WriteLine();
            //};

        }
        //注意：不能写成静态的
        public SqlSugarClient Db;//用来处理事务多表查询和复杂的操作

    }
}
