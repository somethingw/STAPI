using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Prtrol_detail")]
    public partial class Prtrol_detail
    {
           public Prtrol_detail(){


           }
           /// <summary>
           /// Desc:巡检详情
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:ISOID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ISOID {get;set;}

           /// <summary>
           /// Desc:设备类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? devices_type_ID {get;set;}

           /// <summary>
           /// Desc:项目名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string value {get;set;}

           /// <summary>
           /// Desc:巡检类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Patrol_ID {get;set;}

           /// <summary>
           /// Desc:巡检类型标准说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string value_type {get;set;}

    }
}
