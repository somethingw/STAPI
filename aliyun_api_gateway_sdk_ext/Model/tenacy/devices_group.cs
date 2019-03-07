using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("devices_group")]
    public partial class devices_group
    {
           public devices_group(){


           }
           /// <summary>
           /// Desc:设备分组
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:设备分组名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:NFC码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NFC_CODE {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string adress {get;set;}

           /// <summary>
           /// Desc:经度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? location_x {get;set;}

           /// <summary>
           /// Desc:纬度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? location_y {get;set;}

           /// <summary>
           /// Desc:创建者ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? User_ID {get;set;}

           /// <summary>
           /// Desc:使用者ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Now_User_ID {get;set;}

           /// <summary>
           /// Desc:分组类型，10以下代表智能运维，1代表高配间，2代表水泵房，3代表消防泵.10以上代表日常巡检，目前只启用了11.
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? group_type {get;set;}

    }
}
