using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Id2Role2Absauth2User")]
    public partial class Id2Role2Absauth2User
    {
           public Id2Role2Absauth2User(){


           }
           /// <summary>
           /// Desc:身份id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int idno {get;set;}

           /// <summary>
           /// Desc:动态角色id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? roleid {get;set;}

           /// <summary>
           /// Desc:所属组织id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? suserid {get;set;}

    }
}
