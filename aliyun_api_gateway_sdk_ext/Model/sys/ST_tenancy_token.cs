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
    [SugarTable("ST_tenancy_token")]
    public partial class ST_tenancy_token
    {
           public ST_tenancy_token(){


           }
           /// <summary>
           /// Desc:租户免密登陆token信息暂存表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:外键，对应租户主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ten_ID {get;set;}

           /// <summary>
           /// Desc:登陆token
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string token {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

           /// <summary>
           /// Desc:token的状态，0是正常待验证，1是已经使用过，2是失效（判定时用创建时间来判断，失效之后修改为2）
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

            [SugarColumn(IsIgnore = true)]
            public ST_tenancy ST_tenancy { get; set; }

            [SugarColumn(IsIgnore = true)]
            public List<ST_tenancy> ST_tenancys { get; set; }

    }
}
