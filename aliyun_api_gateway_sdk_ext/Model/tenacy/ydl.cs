using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("ydl")]
    public partial class ydl
    {
           public ydl(){


           }
           /// <summary>
           /// Desc:月电量表，项目名
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
           /// Desc:进线编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? tag {get;set;}

    }
}
