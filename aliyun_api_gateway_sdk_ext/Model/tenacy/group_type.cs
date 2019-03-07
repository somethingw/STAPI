using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("group_type")]
    public partial class group_type
    {
           public group_type(){


           }
           /// <summary>
           /// Desc:设备分组类型对应表
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ID {get;set;}

           /// <summary>
           /// Desc:分组类型名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

    }
}
