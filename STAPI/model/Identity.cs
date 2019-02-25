using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace STAPI.model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Identity")]
    public partial class Identity
    {
           public Identity(){


           }
           /// <summary>
           /// Desc:身份ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int idno {get;set;}

           /// <summary>
           /// Desc:身份名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string idname {get;set;}

           /// <summary>
           /// Desc:静态角色ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? sroleid {get;set;}

           /// <summary>
           /// Desc:动态角色ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? droleid {get;set;}

           /// <summary>
           /// Desc:动态组织ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? duserid {get;set;}

    }
}
