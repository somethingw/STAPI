using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Message")]
    public partial class Message
    {
           public Message(){


           }
           /// <summary>
           /// Desc:消息ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int msgid {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? createtime {get;set;}

           /// <summary>
           /// Desc:消息内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string body {get;set;}

           /// <summary>
           /// Desc:链接ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? linkid {get;set;}

           /// <summary>
           /// Desc:链接类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? linktpid {get;set;}

           /// <summary>
           /// Desc:消息类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? msgtpid {get;set;}

           /// <summary>
           /// Desc:发送人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? fromid {get;set;}

           /// <summary>
           /// Desc:接收人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? toid {get;set;}

    }
}
