using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("GPdata")]
    public partial class GPdata
    {
           public GPdata(){


           }
           /// <summary>
           /// Desc:高配数据id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:数据收到时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Period {get;set;}

           /// <summary>
           /// Desc:数据最大值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? maxValue {get;set;}

           /// <summary>
           /// Desc:数据最小值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? minValue {get;set;}

           /// <summary>
           /// Desc:数据平均值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? avgValue {get;set;}

           /// <summary>
           /// Desc:电站名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string projectID {get;set;}

           /// <summary>
           /// Desc:节点类
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
           /// Desc:回路号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HL {get;set;}

    }
}
