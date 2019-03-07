using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("RO2Img")]
    public partial class RO2Img
    {
           public RO2Img(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? roid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string imageurl {get;set;}

    }
}
