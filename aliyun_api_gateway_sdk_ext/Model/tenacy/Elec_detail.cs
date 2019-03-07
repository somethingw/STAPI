using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Elec_detail")]
    public partial class Elec_detail
    {
           public Elec_detail(){


           }
           /// <summary>
           /// Desc:用电详情表
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? id {get;set;}

           /// <summary>
           /// Desc:插入时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? inserttime {get;set;}

           /// <summary>
           /// Desc:电站平台id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string projectid {get;set;}

           /// <summary>
           /// Desc:节点类
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nodeclass {get;set;}

           /// <summary>
           /// Desc:节点名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nodename {get;set;}

           /// <summary>
           /// Desc:回路名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HL {get;set;}

           /// <summary>
           /// Desc:峰电量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? peakelec {get;set;}

           /// <summary>
           /// Desc:谷电量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? valleyelec {get;set;}

           /// <summary>
           /// Desc:平电量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? flatelec {get;set;}

           /// <summary>
           /// Desc:总用点量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? sumelec {get;set;}

    }
}
