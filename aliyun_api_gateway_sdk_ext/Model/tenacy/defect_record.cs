using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("defect_record")]
    public partial class defect_record
    {
           public defect_record(){


           }
           /// <summary>
           /// Desc:缺陷记录
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

           /// <summary>
           /// Desc:巡检人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Patrol_man_ID {get;set;}

           /// <summary>
           /// Desc:设备类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? devices_type_ID {get;set;}

           /// <summary>
           /// Desc:设备ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? devices_ID {get;set;}

           /// <summary>
           /// Desc:ISOID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ISOID {get;set;}

           /// <summary>
           /// Desc:批次号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public Guid? batch {get;set;}

           /// <summary>
           /// Desc:账单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? order_ID {get;set;}

           /// <summary>
           /// Desc:事项名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

    }
}
