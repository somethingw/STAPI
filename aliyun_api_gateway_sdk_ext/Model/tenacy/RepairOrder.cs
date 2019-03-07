using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("RepairOrder")]
    public partial class RepairOrder
    {
           public RepairOrder(){


           }
           /// <summary>
           /// Desc:维修单ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int roid {get;set;}

           /// <summary>
           /// Desc:报修单ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int crid {get;set;}

           /// <summary>
           /// Desc:主维修员ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? rmid {get;set;}

           /// <summary>
           /// Desc:派单组织ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ctid {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

           /// <summary>
           /// Desc:维修单状态ID
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? rosid {get;set;}

           /// <summary>
           /// Desc:评价
           /// Default:-1
           /// Nullable:True
           /// </summary>           
           public int? rating {get;set;}

           /// <summary>
           /// Desc:预约上门时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? bookgotime {get;set;}

           /// <summary>
           /// Desc:预约上门时间段
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? booktqid {get;set;}

           /// <summary>
           /// Desc:物业公司ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? companyid {get;set;}

           /// <summary>
           /// Desc:管理处ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? orgid {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? brptime {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? erptime {get;set;}

    }
}
