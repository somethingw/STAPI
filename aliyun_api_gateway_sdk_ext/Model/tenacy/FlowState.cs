using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("FlowState")]
    public partial class FlowState
    {
           public FlowState(){


           }
           /// <summary>
           /// Desc:流程状态ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int fsid {get;set;}

           /// <summary>
           /// Desc:流程状态名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

    }
}
