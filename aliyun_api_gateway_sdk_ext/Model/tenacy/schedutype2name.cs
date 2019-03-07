using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("schedutype2name")]
    public partial class schedutype2name
    {
           public schedutype2name(){


           }
           /// <summary>
           /// Desc:工作排班类型对应表
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? schedutypeid {get;set;}

           /// <summary>
           /// Desc:类型名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string typename {get;set;}

           /// <summary>
           /// Desc:此类型排班总共天数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? totalday {get;set;}

    }
}
