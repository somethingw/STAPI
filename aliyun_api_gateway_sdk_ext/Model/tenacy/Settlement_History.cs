using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Settlement_History")]
    public partial class Settlement_History
    {
           public Settlement_History(){


           }
           /// <summary>
           /// Desc:结算历史表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:结算人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Settlement_man {get;set;}

           /// <summary>
           /// Desc:维修员姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string repair_man {get;set;}

           /// <summary>
           /// Desc:结算金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? total {get;set;}

           /// <summary>
           /// Desc:时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

           /// <summary>
           /// Desc:批次号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public Guid? batch {get;set;}

           /// <summary>
           /// Desc:维修单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? repair_ID {get;set;}

    }
}
