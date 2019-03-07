using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("ST_device")]
    public partial class ST_device
    {
           public ST_device(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string productKey {get;set;}

           /// <summary>
           /// Desc:
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

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string iotid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int status {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tenancyid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string appid {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? createtime {get;set;}

           /// <summary>
           /// Desc:租户端设备名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ten_devicename {get;set;}

           /// <summary>
           /// Desc:租户端设备ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ten_deviceid {get;set;}

           /// <summary>
           /// Desc:租户的设备码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ten_devicecode {get;set;}

    }
}
