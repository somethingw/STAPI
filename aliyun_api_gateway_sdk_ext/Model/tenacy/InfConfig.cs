using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("InfConfig")]
    public partial class InfConfig
    {
           public InfConfig(){


           }
           /// <summary>
           /// Desc:Lora二进制配置表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int infid {get;set;}

           /// <summary>
           /// Desc:设备ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int devices_ID {get;set;}

           /// <summary>
           /// Desc:传感器编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sen_code {get;set;}

           /// <summary>
           /// Desc:范围
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string runrange {get;set;}

           /// <summary>
           /// Desc:位数，低位开始
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? bytenum {get;set;}

           /// <summary>
           /// Desc:传感器名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string senname {get;set;}

           /// <summary>
           /// Desc:报警值
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? alert {get;set;}

    }
}
