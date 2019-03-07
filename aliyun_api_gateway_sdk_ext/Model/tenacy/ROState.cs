using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("ROState")]
    public partial class ROState
    {
           public ROState(){


           }
           /// <summary>
           /// Desc:维修单状态ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int rosid {get;set;}

           /// <summary>
           /// Desc:维修单状态名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

    }
}
