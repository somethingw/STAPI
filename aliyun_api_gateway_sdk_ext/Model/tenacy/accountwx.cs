using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("accountwx")]
    public partial class accountwx
    {
           public accountwx(){


           }
           /// <summary>
           /// Desc:微信用户表 openid(用户唯一标识）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string openid {get;set;}

           /// <summary>
           /// Desc:昵称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nickname {get;set;}

           /// <summary>
           /// Desc:性别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? sex {get;set;}

           /// <summary>
           /// Desc:城市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string city {get;set;}

           /// <summary>
           /// Desc:头像地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string headimgurl {get;set;}

           /// <summary>
           /// Desc:unionid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string unionid {get;set;}

    }
}
