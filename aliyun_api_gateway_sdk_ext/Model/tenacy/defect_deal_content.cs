using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("defect_deal_content")]
    public partial class defect_deal_content
    {
           public defect_deal_content(){


           }
           /// <summary>
           /// Desc:缺陷处理内容
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:缺陷表主键ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? defect_bath_ID {get;set;}

           /// <summary>
           /// Desc:处理表ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? chuli_ID {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mark_content {get;set;}

           /// <summary>
           /// Desc:处理时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? deal_time {get;set;}

           /// <summary>
           /// Desc:处理类型，0代表正常，1代表异常，2代表严重事件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? confirm_type {get;set;}

    }
}
