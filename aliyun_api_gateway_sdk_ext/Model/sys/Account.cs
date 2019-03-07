using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Account")]
    public partial class Account
    {
           public Account(){


           }
           /// <summary>
           /// Desc:账号ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string accountid {get;set;}

           /// <summary>
           /// Desc:密码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string password {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userid {get;set;}

           /// <summary>
           /// Desc:身份ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? idno {get;set;}

           /// <summary>
           /// Desc:是否有效
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int isuse {get;set;}

    }
}
