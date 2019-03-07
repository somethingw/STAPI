using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("ST_tenancy_log")]
    public partial class ST_tenancy_log
    {
           public ST_tenancy_log(){


           }
           /// <summary>
           /// Desc:租户行为日志
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:租户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ten_ID {get;set;}

           /// <summary>
           /// Desc:用户行为分类，BUY为购买，TRIAL为试用，DETORY为回收销毁
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string type {get;set;}

           /// <summary>
           /// Desc:行为备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? time {get;set;}

           /// <summary>
           /// Desc:行为类型，0标识正常业务流程，1标识系统管理员强制操作
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? con_type {get;set;}

    }
}
