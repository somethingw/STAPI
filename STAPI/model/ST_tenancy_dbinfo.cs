using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace STAPI.model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("ST_tenancy_dbinfo")]
    public partial class ST_tenancy_dbinfo
    {
           public ST_tenancy_dbinfo(){


           }
           /// <summary>
           /// Desc:数据库信息表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:数据库地址
           /// Default:127.0.0.1
           /// Nullable:False
           /// </summary>           
           public string host {get;set;}

           /// <summary>
           /// Desc:数据库名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string dbName {get;set;}

           /// <summary>
           /// Desc:状态码，0标识待用，1表示启用，2表示待回收
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int status {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Mark {get;set;}

    }
}
