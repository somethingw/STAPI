using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("inspect2cycle")]
    public partial class inspect2cycle
    {
           public inspect2cycle(){


           }
           /// <summary>
           /// Desc:巡检周期表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int cycleid {get;set;}

           /// <summary>
           /// Desc:巡检周期名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cyclename {get;set;}

           /// <summary>
           /// Desc:巡检周期单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cycleunit {get;set;}

           /// <summary>
           /// Desc:巡检周期跨度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? cyclepass {get;set;}

           /// <summary>
           /// Desc:巡检报警阈值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? cyclealarm {get;set;}

    }
}
