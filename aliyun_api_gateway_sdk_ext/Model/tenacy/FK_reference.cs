using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("FK_reference")]
    public partial class FK_reference
    {
           public FK_reference(){


           }
           /// <summary>
           /// Desc:账单详情
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:收费项目名
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
           /// Desc:单价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? count {get;set;}

           /// <summary>
           /// Desc:总价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? total {get;set;}

           /// <summary>
           /// Desc:帐单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? bill_ID {get;set;}

           /// <summary>
           /// Desc:工时
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public double? cost_time {get;set;}

           /// <summary>
           /// Desc:物料ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? PID {get;set;}

           /// <summary>
           /// Desc:工时小计
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? cost_time_count {get;set;}

           /// <summary>
           /// Desc:0是物料，1是工时
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? type {get;set;}

    }
}
