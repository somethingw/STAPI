using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("ST_tenancy_to_db")]
    public partial class ST_tenancy_to_db
    {
           public ST_tenancy_to_db(){


           }
           /// <summary>
           /// Desc:租户数据库关系表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:租户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ten_ID {get;set;}

           /// <summary>
           /// Desc:数据库ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int db_ID {get;set;}

    }
}
