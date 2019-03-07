using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("devices")]
    public partial class devices
    {
           public devices(){


           }
           /// <summary>
           /// Desc:设备表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:设备名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:设备码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string device_code {get;set;}

           /// <summary>
           /// Desc:NFC码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FNC_CODE {get;set;}

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
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string adress {get;set;}

           /// <summary>
           /// Desc:设备类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? devices_type_ID {get;set;}

           /// <summary>
           /// Desc:设备分组ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? group_ID {get;set;}

           /// <summary>
           /// Desc:是否有传感器
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? IS_sensor {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? User_ID {get;set;}

           /// <summary>
           /// Desc:回路号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HL {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? time {get;set;}

           /// <summary>
           /// Desc:出场时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CC_time {get;set;}

           /// <summary>
           /// Desc:投入使用时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SY_time {get;set;}

           /// <summary>
           /// Desc:到期时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? END_time {get;set;}

           /// <summary>
           /// Desc:年限 ，单位为月
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? NX {get;set;}

           /// <summary>
           /// Desc:设备当前状态，0是待提交审核，1是审核中，2是已审核（待接入），3是已接入,4是已失效（阿里云删除）。
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? tag {get;set;}

           /// <summary>
           /// Desc:iot平台的唯一id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string iotId {get;set;}

           /// <summary>
           /// Desc:设备所隶属的产品Key。
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string productKey {get;set;}

           /// <summary>
           /// Desc:iot平台设备名称。
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string deviceName {get;set;}

           /// <summary>
           /// Desc:设备密钥
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string deviceSecret {get;set;}

    }
}
