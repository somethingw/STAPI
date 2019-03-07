using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("accout2pic")]
    public partial class accout2pic
    {
           public accout2pic(){


           }
           /// <summary>
           /// Desc:用户头像对应表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int picid {get;set;}

           /// <summary>
           /// Desc:用户id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string accountid {get;set;}

           /// <summary>
           /// Desc:图片地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string urlsrc {get;set;}

           /// <summary>
           /// Desc:上传时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? uploadtime {get;set;}

           /// <summary>
           /// Desc:服务器id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? serverid {get;set;}

           /// <summary>
           /// Desc:是否再用 1在用中 0未使用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? isnow {get;set;}

    }
}
