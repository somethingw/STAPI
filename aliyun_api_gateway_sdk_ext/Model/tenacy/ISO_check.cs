using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("ISO_check")]
    public partial class ISO_check
    {
           public ISO_check(){


           }
           /// <summary>
           /// Desc:ISO配置表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:配置名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:对应设备类型id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? devices_type_ID {get;set;}

           /// <summary>
           /// Desc:ISO类型，0是传感器监控型，1是人力巡检型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? value_type {get;set;}

    }
}
