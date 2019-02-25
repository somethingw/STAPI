using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace STAPI.model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("ST_app_apply")]
    public partial class ST_app_apply
    {
           public ST_app_apply(){


           }
           /// <summary>
           /// Desc:申请id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int applyid {get;set;}

           /// <summary>
           /// Desc:租户id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? tenUid {get;set;}

           /// <summary>
           /// Desc:app名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string appName {get;set;}

           /// <summary>
           /// Desc:公司名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string gsName {get;set;}

           /// <summary>
           /// Desc:图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string logo {get;set;}

           /// <summary>
           /// Desc:联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string contacts {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tel {get;set;}

           /// <summary>
           /// Desc:申请时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? applytime {get;set;}

           /// <summary>
           /// Desc:处理时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? dealtime {get;set;}

           /// <summary>
           /// Desc:处理完成时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? finishtime {get;set;}

           /// <summary>
           /// Desc:处理状态：0是待处理；1是处理中；2是处理完成
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

           /// <summary>
           /// Desc:居民端url
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string resident_url {get;set;}

           /// <summary>
           /// Desc:维修端url
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string service_url {get;set;}

    }
}
