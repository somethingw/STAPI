using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tp_node_alaert_history")]
    public partial class tp_node_alaert_history
    {
           public tp_node_alaert_history(){


           }
           /// <summary>
           /// Desc:报警历史表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? User_ID {get;set;}

           /// <summary>
           /// Desc:项目名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:设备名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string dename {get;set;}

           /// <summary>
           /// Desc:类型名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string typename {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mark {get;set;}

           /// <summary>
           /// Desc:状态，0未，1已
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? createtime {get;set;}

           /// <summary>
           /// Desc:值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? value {get;set;}

           /// <summary>
           /// Desc:设备编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string devices_code {get;set;}

           /// <summary>
           /// Desc:传感器标准编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sen_code {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? type {get;set;}

           /// <summary>
           /// Desc:高配间ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? gaopei_ID {get;set;}

           /// <summary>
           /// Desc:设备ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? devices_ID {get;set;}

           /// <summary>
           /// Desc:处理ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? deal_ID {get;set;}

           /// <summary>
           /// Desc:处理时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? deal_time {get;set;}

           /// <summary>
           /// Desc:批次号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public Guid? batch {get;set;}

    }
}
