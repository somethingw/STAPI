using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Authtp2ctrltp")]
    public partial class Authtp2ctrltp
    {
           public Authtp2ctrltp(){


           }
           /// <summary>
           /// Desc:权限类型和操作类型对应表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:权限类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? authtpid {get;set;}

           /// <summary>
           /// Desc:控制类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ctrltpid {get;set;}

    }
}
