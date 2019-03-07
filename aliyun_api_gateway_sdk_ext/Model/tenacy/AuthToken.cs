using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("AuthToken")]
    public partial class AuthToken
    {
           public AuthToken(){


           }
           /// <summary>
           /// Desc:登录令牌
           /// Default:replace(newid(),'-','')
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string token {get;set;}

           /// <summary>
           /// Desc:账号ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string accountid {get;set;}

           /// <summary>
           /// Desc:生成时间
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime createtime {get;set;}

           /// <summary>
           /// Desc:过期时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime expiredtime {get;set;}

           /// <summary>
           /// Desc:是否有效
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int available {get;set;}

    }
}
