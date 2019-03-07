using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("B")]
    public partial class B
    {
           public B(){


           }
           /// <summary>
           /// Desc:此表为缓存表，时间段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Period {get;set;}

           /// <summary>
           /// Desc:值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? AvgValue {get;set;}

           /// <summary>
           /// Desc:节点名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NodeName {get;set;}

    }
}
