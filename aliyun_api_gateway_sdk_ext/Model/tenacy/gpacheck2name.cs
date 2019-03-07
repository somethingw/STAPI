using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("gpacheck2name")]
    public partial class gpacheck2name
    {
           public gpacheck2name(){


           }
           /// <summary>
           /// Desc:缺陷查核id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? checkid {get;set;}

           /// <summary>
           /// Desc:缺陷是否查核
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string checkname {get;set;}

    }
}
