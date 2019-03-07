using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Survey")]
    public partial class Survey
    {
           public Survey(){


           }
           /// <summary>
           /// Desc:高配间基础配置
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:电站唯一ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string projectID {get;set;}

           /// <summary>
           /// Desc:电压等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Leval {get;set;}

           /// <summary>
           /// Desc:电站名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:基本信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Info {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Adress {get;set;}

           /// <summary>
           /// Desc:经度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? location_x {get;set;}

           /// <summary>
           /// Desc:纬度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? location_y {get;set;}

           /// <summary>
           /// Desc:电站容量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string capacity {get;set;}

           /// <summary>
           /// Desc:主变台数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Transformer_num {get;set;}

           /// <summary>
           /// Desc:高压台数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? H_Power {get;set;}

           /// <summary>
           /// Desc:低压台数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? L_Power {get;set;}

           /// <summary>
           /// Desc:启用时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? Time {get;set;}

           /// <summary>
           /// Desc:报警值0
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Alert_0 {get;set;}

           /// <summary>
           /// Desc:报警值1，预留
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Alert_1 {get;set;}

           /// <summary>
           /// Desc:报警值2，预留
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Alert_2 {get;set;}

           /// <summary>
           /// Desc:缺陷值0
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Defect_0 {get;set;}

           /// <summary>
           /// Desc:缺陷值1，未启用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Defect_1 {get;set;}

           /// <summary>
           /// Desc:缺陷值2，未启用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Defect_2 {get;set;}

           /// <summary>
           /// Desc:本月总量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ZL_Now_Month {get;set;}

           /// <summary>
           /// Desc:上月总量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ZL_Pre_Month {get;set;}

           /// <summary>
           /// Desc:本年总量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ZL_Now_Year {get;set;}

           /// <summary>
           /// Desc:去年总量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ZL_Pre_Year {get;set;}

           /// <summary>
           /// Desc:本月最大负荷
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? FH_Now_Month {get;set;}

           /// <summary>
           /// Desc:上月最大负荷
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? FH_Pre_Month {get;set;}

           /// <summary>
           /// Desc:本年最大负荷
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? FH_Now_Year {get;set;}

           /// <summary>
           /// Desc:去年最大负荷
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? FH_Pre_Year {get;set;}

           /// <summary>
           /// Desc:需量名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string XL_Name {get;set;}

           /// <summary>
           /// Desc:本月需量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? XL_Now_Month {get;set;}

           /// <summary>
           /// Desc:需量上报时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? XL_Time {get;set;}

           /// <summary>
           /// Desc:本月申报值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? XL_Decl {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Mark {get;set;}

           /// <summary>
           /// Desc:对应前台展示页面
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HTML {get;set;}

           /// <summary>
           /// Desc:总线配置
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string totel_line {get;set;}

           /// <summary>
           /// Desc:分组ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? group_ID {get;set;}

    }
}
