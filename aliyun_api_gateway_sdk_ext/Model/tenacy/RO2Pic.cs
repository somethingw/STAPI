using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("RO2Pic")]
    public partial class RO2Pic
    {
           public RO2Pic(){


           }
           /// <summary>
           /// Desc:图片和维修单对应关系表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int picid {get;set;}

           /// <summary>
           /// Desc:维修单id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string roid {get;set;}

           /// <summary>
           /// Desc:单子状态id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string fsid {get;set;}

           /// <summary>
           /// Desc:上传账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string accountid {get;set;}

           /// <summary>
           /// Desc:url地址
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
           /// Desc:服务器id号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? serverid {get;set;}

    }
}
