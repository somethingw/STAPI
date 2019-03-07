using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("inspectplan")]
    public partial class inspectplan
    {
           public inspectplan(){


           }
           /// <summary>
           /// Desc:巡检地所属设备分组id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int inspegroupid {get;set;}

           /// <summary>
           /// Desc:巡检地址
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string inspegroupadress {get;set;}

           /// <summary>
           /// Desc:巡检周期id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? inspecycleid {get;set;}

           /// <summary>
           /// Desc:主要巡检人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? inspecmainid {get;set;}

           /// <summary>
           /// Desc:所有巡检员id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string weixiumanid {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? starttime {get;set;}

           /// <summary>
           /// Desc:巡检计划是否启动 0 未启动 1 已启动
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? isstart {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? endtime {get;set;}

           /// <summary>
           /// Desc:巡检规则id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int planid {get;set;}

    }
}
