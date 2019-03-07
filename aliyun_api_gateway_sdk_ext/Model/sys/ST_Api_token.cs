using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("ST_Api_token")]
    public partial class ST_Api_token
    {
           public ST_Api_token(){


           }
           /// <summary>
           /// Desc:对外API表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string appKey {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string appSecret {get;set;}

           /// <summary>
           /// Desc:租户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ten_ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mark {get;set;}

    }
}
