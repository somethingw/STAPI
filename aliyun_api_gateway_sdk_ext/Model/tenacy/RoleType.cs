using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("RoleType")]
    public partial class RoleType
    {
           public RoleType(){


           }
           /// <summary>
           /// Desc:角色类型id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int roletypeid {get;set;}

           /// <summary>
           /// Desc:角色类型名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string roletypename {get;set;}

    }
}
