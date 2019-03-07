using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Role2Auth")]
    public partial class Role2Auth
    {
           public Role2Auth(){


           }
           /// <summary>
           /// Desc:静态角色id号（静态角色权限对应关系表）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? roleid {get;set;}

           /// <summary>
           /// Desc:权限id号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? authid {get;set;}

    }
}
