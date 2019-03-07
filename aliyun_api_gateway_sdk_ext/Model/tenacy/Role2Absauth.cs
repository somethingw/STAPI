using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Role2Absauth")]
    public partial class Role2Absauth
    {
           public Role2Absauth(){


           }
           /// <summary>
           /// Desc:动态角色id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int roleid {get;set;}

           /// <summary>
           /// Desc:权限动作类型id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ctrltpid {get;set;}

           /// <summary>
           /// Desc:组织userid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? duserid {get;set;}

           /// <summary>
           /// Desc:动态角色名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string rolename {get;set;}

           /// <summary>
           /// Desc:权限类型id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? authtpid {get;set;}

    }
}
