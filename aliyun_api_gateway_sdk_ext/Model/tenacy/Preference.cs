using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Preference")]
    public partial class Preference
    {
           public Preference(){


           }
           /// <summary>
           /// Desc:收费标准
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:项目名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? price {get;set;}

           /// <summary>
           /// Desc:单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string unit {get;set;}

           /// <summary>
           /// Desc:工时
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? cost_time {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remarks {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? User_ID {get;set;}

           /// <summary>
           /// Desc:收费项目类型，0是物耗，1是人工时
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? type {get;set;}

    }
}
