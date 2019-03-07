using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("CallRepair")]
    public partial class CallRepair
    {
           public CallRepair(){


           }
           /// <summary>
           /// Desc:报修单ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int crid {get;set;}

           /// <summary>
           /// Desc:部位类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? pttpid {get;set;}

           /// <summary>
           /// Desc:部位ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ptid {get;set;}

           /// <summary>
           /// Desc:详细描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string desc {get;set;}

           /// <summary>
           /// Desc:预约时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime booktime {get;set;}

           /// <summary>
           /// Desc:房屋ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? houseid {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tel {get;set;}

           /// <summary>
           /// Desc:报修人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string caller {get;set;}

           /// <summary>
           /// Desc:流程状态ID
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? fsid {get;set;}

           /// <summary>
           /// Desc:报修账号ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string accountid {get;set;}

           /// <summary>
           /// Desc:报修时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? calltime {get;set;}

           /// <summary>
           /// Desc:预约时间段ID
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? booktqid {get;set;}

           /// <summary>
           /// Desc:房屋类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? hsstid {get;set;}

           /// <summary>
           /// Desc:报修来源ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int sourceid {get;set;}

    }
}
