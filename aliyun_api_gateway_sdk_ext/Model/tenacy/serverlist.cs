using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("serverlist")]
    public partial class serverlist
    {
           public serverlist(){


           }
           /// <summary>
           /// Desc:图片服务器ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? serverid {get;set;}

           /// <summary>
           /// Desc:图片服务器地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string url {get;set;}

           /// <summary>
           /// Desc:图片服务器IP
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ip {get;set;}

           /// <summary>
           /// Desc:图片服务器名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

    }
}
