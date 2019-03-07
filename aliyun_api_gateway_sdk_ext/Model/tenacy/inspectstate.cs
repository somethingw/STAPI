using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("inspectstate")]
    public partial class inspectstate
    {
           public inspectstate(){


           }
           /// <summary>
           /// Desc:巡检计划完成状态表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:巡检计划id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int planid {get;set;}

           /// <summary>
           /// Desc:主要巡检人id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int inspemainid {get;set;}

           /// <summary>
           /// Desc:当前巡检状态id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? inspestateid {get;set;}

           /// <summary>
           /// Desc:计划开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? planstarttime {get;set;}

           /// <summary>
           /// Desc:计划结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? planendtime {get;set;}

           /// <summary>
           /// Desc:隶属设备分组id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? groupid {get;set;}

           /// <summary>
           /// Desc:完成人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? whodoid {get;set;}

           /// <summary>
           /// Desc:完成时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? whodotime {get;set;}

    }
}
