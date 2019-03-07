using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("scheduban2name")]
    public partial class scheduban2name
    {
           public scheduban2name(){


           }
           /// <summary>
           /// Desc:班次号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? clbanid {get;set;}

           /// <summary>
           /// Desc:班次名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string banname {get;set;}

           /// <summary>
           /// Desc:排班类型id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? schedutypeid {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sttime {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string edtime {get;set;}

           /// <summary>
           /// Desc:颜色
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string color {get;set;}

           /// <summary>
           /// Desc:背景色
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bgcolor {get;set;}

           /// <summary>
           /// Desc:时间跨度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? spanlong {get;set;}

    }
}
