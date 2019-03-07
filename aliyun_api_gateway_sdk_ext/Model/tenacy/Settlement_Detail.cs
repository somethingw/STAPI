using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Settlement_Detail")]
    public partial class Settlement_Detail
    {
           public Settlement_Detail(){


           }
           /// <summary>
           /// Desc:结算详情表
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:结算ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Settlement_ID {get;set;}

           /// <summary>
           /// Desc:账单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? order_ID {get;set;}

           /// <summary>
           /// Desc:结算金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? total {get;set;}

    }
}
