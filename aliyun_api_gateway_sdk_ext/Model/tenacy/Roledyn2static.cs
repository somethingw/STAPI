using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Roledyn2static")]
    public partial class Roledyn2static
    {
           public Roledyn2static(){


           }
           /// <summary>
           /// Desc:动态角色与静态角色对应关系表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:动态角色id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? droleid {get;set;}

           /// <summary>
           /// Desc:静态角色id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? sroleid {get;set;}

    }
}
