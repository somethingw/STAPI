using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("rxl")]
    public partial class rxl
    {
           public rxl(){


           }
           /// <summary>
           /// Desc:日需量表，项目名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProjectName {get;set;}

           /// <summary>
           /// Desc:时间段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Period {get;set;}

           /// <summary>
           /// Desc:值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? AvgValue {get;set;}

           /// <summary>
           /// Desc:节点名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NodeName {get;set;}

           /// <summary>
           /// Desc:0代表今天，1代表昨天
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? type {get;set;}

    }
}
