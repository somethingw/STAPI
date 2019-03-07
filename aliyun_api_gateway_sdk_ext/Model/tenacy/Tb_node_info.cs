using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Tb_node_info")]
    public partial class Tb_node_info
    {
           public Tb_node_info(){


           }
           /// <summary>
           /// Desc:webservice节点信息配置表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:节点ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nodeID {get;set;}

           /// <summary>
           /// Desc:节点名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nodeName {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? User_ID {get;set;}

           /// <summary>
           /// Desc:分组ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? group_ID {get;set;}

    }
}
