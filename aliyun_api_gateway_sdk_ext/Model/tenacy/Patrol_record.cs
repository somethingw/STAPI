using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Patrol_record")]
    public partial class Patrol_record
    {
           public Patrol_record(){


           }
           /// <summary>
           /// Desc:巡检记录表
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
           /// Desc:设备ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? devices_ID {get;set;}

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
           /// Desc:NFC码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NFC {get;set;}

    }
}
