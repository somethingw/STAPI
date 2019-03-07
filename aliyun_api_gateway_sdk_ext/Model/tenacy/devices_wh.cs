using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("devices_wh")]
    public partial class devices_wh
    {
           public devices_wh(){


           }
           /// <summary>
           /// Desc:设备维护表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:类型,0为保养，1为维修
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? type {get;set;}

           /// <summary>
           /// Desc:维护记录
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mark {get;set;}

           /// <summary>
           /// Desc:维护人手机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string phone {get;set;}

           /// <summary>
           /// Desc:维护人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:维护时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? time {get;set;}

           /// <summary>
           /// Desc:设备ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? devices_ID {get;set;}

    }
}
