using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("short_message")]
    public partial class short_message
    {
           public short_message(){


           }
           /// <summary>
           /// Desc:短信表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:手机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string phone {get;set;}

           /// <summary>
           /// Desc:短信内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string message {get;set;}

           /// <summary>
           /// Desc:状态，0未发送，1已发送
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

           /// <summary>
           /// Desc:时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? time {get;set;}

           /// <summary>
           /// Desc:报警ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? alert_ID {get;set;}

           /// <summary>
           /// Desc:信息类型，1为断线报警，2为阈值报警
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? type {get;set;}

           /// <summary>
           /// Desc:项目地址
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
           /// Desc:设备类型名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string typename {get;set;}

           /// <summary>
           /// Desc:传感器编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sen_code {get;set;}

           /// <summary>
           /// Desc:值
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public double? value {get;set;}

    }
}
