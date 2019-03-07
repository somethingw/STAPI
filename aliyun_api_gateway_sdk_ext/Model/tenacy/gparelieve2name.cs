using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("gparelieve2name")]
    public partial class gparelieve2name
    {
           public gparelieve2name(){


           }
           /// <summary>
           /// Desc:报警解除id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? relieveid {get;set;}

           /// <summary>
           /// Desc:报警是否解除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string relievename {get;set;}

    }
}
