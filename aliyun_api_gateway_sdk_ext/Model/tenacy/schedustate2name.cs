using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("schedustate2name")]
    public partial class schedustate2name
    {
           public schedustate2name(){


           }
           /// <summary>
           /// Desc:工作排班状态表
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? schedustate {get;set;}

           /// <summary>
           /// Desc:排班状态名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string statename {get;set;}

    }
}
