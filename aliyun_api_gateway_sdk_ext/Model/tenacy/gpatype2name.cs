using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("gpatype2name")]
    public partial class gpatype2name
    {
           public gpatype2name(){


           }
           /// <summary>
           /// Desc:高配事件类型id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? alarmtypeid {get;set;}

           /// <summary>
           /// Desc:高配事件类型名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string alarmtypename {get;set;}

    }
}
