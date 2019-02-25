using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace STAPI.model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Authority")]
    public partial class Authority
    {
           public Authority(){


           }
           /// <summary>
           /// Desc:权限ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int authid {get;set;}

           /// <summary>
           /// Desc:权限名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string authname {get;set;}

           /// <summary>
           /// Desc:权限类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? authtpid {get;set;}

           /// <summary>
           /// Desc:组织ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userid {get;set;}

           /// <summary>
           /// Desc:控制类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ctrltpid {get;set;}

           /// <summary>
           /// Desc:权限码
           /// Default:replace(newid(),'-','')
           /// Nullable:True
           /// </summary>           
           public string fncode {get;set;}

    }
}
