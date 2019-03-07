using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("HISTORYNUMERICTRENDRECORD_now")]
    public partial class HISTORYNUMERICTRENDRECORD_now
    {
           public HISTORYNUMERICTRENDRECORD_now(){


           }
           /// <summary>
           /// Desc:N4缓存表，各字段同N4表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? TIMESTAMP {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? TRENDFLAGS {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? STATUS {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? VALUE {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HISTORY_ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TRENDFLAGS_TAG {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STATUS_TAG {get;set;}

           /// <summary>
           /// Desc:状态更改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? change_time {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int tag {get;set;}

           /// <summary>
           /// Desc:设备名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string de_name {get;set;}

           /// <summary>
           /// Desc:传感器名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string se_name {get;set;}

    }
}
