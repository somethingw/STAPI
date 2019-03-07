using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("ST_tenancy")]
    public partial class ST_tenancy
    {
           public ST_tenancy(){


           }
           /// <summary>
           /// Desc:租户信息表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:访问id，对应租户创建接口的
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ac_id {get;set;}

           /// <summary>
           /// Desc:租户在阿里平台的唯一ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tenantid {get;set;}

           /// <summary>
           /// Desc:租户此次购买的应用的唯一id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string appid {get;set;}

           /// <summary>
           /// Desc:租户类型，"TRIAL":试⽤， ⽤户可以有⼀个短暂的试⽤期， 该功能在商品上架时ISV可以选择是否 提供试⽤逻辑
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string apptype {get;set;}

           /// <summary>
           /// Desc:生效时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

           /// <summary>
           /// Desc:到期时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? end_time {get;set;}

           /// <summary>
           /// Desc:0是禁用，1是启用
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

           /// <summary>
           /// Desc:备用唯一标识串
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GUID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Mark {get;set;}
           public string appKey { get; set; }
           public string appSecret { get; set; }
           

    }
}
