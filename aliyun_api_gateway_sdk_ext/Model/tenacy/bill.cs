using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("bill")]
    public partial class bill
    {
           public bill(){


           }
           /// <summary>
           /// Desc:账单类型，0是普通账单，1是虚拟账单，2是维修基金账单
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:账单类型，1代表报价单，2代表账单
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? bill_type {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? create_time {get;set;}

           /// <summary>
           /// Desc:总价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? total {get;set;}

           /// <summary>
           /// Desc:是否支付，0代表未支付，1代表支付
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? ispay {get;set;}

           /// <summary>
           /// Desc:维修单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? order_ID {get;set;}

           /// <summary>
           /// Desc:批次号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public Guid? batch {get;set;}

           /// <summary>
           /// Desc:支付方式,0是现金，1是支付宝，2是微信，3是银行卡
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? pay_type {get;set;}

           /// <summary>
           /// Desc:总工时
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public double? cost {get;set;}

           /// <summary>
           /// Desc:总费用，等于总工时加上总价格
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ALL_Total {get;set;}

           /// <summary>
           /// Desc:工时收费单价
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public double? GS {get;set;}

    }
}
