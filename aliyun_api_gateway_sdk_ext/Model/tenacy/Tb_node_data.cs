using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Tb_node_data")]
    public partial class Tb_node_data
    {
           public Tb_node_data(){


           }
           /// <summary>
           /// Desc:webservice数据源表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:项目名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string projectID {get;set;}

           /// <summary>
           /// Desc:节点编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nodeClass {get;set;}

           /// <summary>
           /// Desc:节点名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nodeName {get;set;}

           /// <summary>
           /// Desc:节点值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? nodeVal {get;set;}

           /// <summary>
           /// Desc:信号质量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string quality {get;set;}

           /// <summary>
           /// Desc:时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nodeTime {get;set;}

           /// <summary>
           /// Desc:节点源文
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nodeTxt {get;set;}

           /// <summary>
           /// Desc:收到时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? recvTime {get;set;}

           /// <summary>
           /// Desc:回路号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HL {get;set;}

    }
}
