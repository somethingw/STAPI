using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Authtp2authid")]
    public partial class Authtp2authid
    {
           public Authtp2authid(){


           }
           /// <summary>
           /// Desc:权限类型ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int authtpid {get;set;}

           /// <summary>
           /// Desc:权限ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? authid {get;set;}

    }
}
