using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("insplan2man")]
    public partial class insplan2man
    {
           public insplan2man(){


           }
           /// <summary>
           /// Desc:巡检计划id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int planid {get;set;}

           /// <summary>
           /// Desc:主要负责人userid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int mainid {get;set;}

           /// <summary>
           /// Desc:巡检人id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int inspemanid {get;set;}

           /// <summary>
           /// Desc:是否完成 1完成 0 未完成
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? isdo {get;set;}

           /// <summary>
           /// Desc:完成时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? dotime {get;set;}

    }
}
