using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("scheducalendar")]
    public partial class scheducalendar
    {
           public scheducalendar(){


           }
           /// <summary>
           /// Desc:排班计划id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? planid {get;set;}

           /// <summary>
           /// Desc:用户id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userid {get;set;}

           /// <summary>
           /// Desc:班次id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? clbanid {get;set;}

           /// <summary>
           /// Desc:日期号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string datehao {get;set;}

           /// <summary>
           /// Desc:年份和月号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string monthhao {get;set;}

           /// <summary>
           /// Desc:值班日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? cldate {get;set;}

           /// <summary>
           /// Desc:当前排班类型的第几天
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? orderday {get;set;}

    }
}
