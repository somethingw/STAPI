using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("group_to_message")]
    public partial class group_to_message
    {
           public group_to_message(){


           }
           /// <summary>
           /// Desc:分组短信服务配置表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:设备分组ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? group_ID {get;set;}

           /// <summary>
           /// Desc:管理人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:管理人联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string phone {get;set;}

           /// <summary>
           /// Desc:备注信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mark {get;set;}

           /// <summary>
           /// Desc:启用状态，0是未启用，1是启用
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

    }
}
