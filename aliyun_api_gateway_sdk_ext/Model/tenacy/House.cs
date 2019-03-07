using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("House")]
    public partial class House
    {
           public House(){


           }
           /// <summary>
           /// Desc:房屋ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int houseid {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string address {get;set;}

           /// <summary>
           /// Desc:房屋类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? hsstid {get;set;}

           /// <summary>
           /// Desc:所属管理处名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ctid {get;set;}

           /// <summary>
           /// Desc:联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string hmtel {get;set;}

           /// <summary>
           /// Desc:是否可被修改
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? available {get;set;}

           /// <summary>
           /// Desc:省市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string province {get;set;}

           /// <summary>
           /// Desc:区县
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string district {get;set;}

           /// <summary>
           /// Desc:路
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string road {get;set;}

           /// <summary>
           /// Desc:公司名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string gongsiname {get;set;}

           /// <summary>
           /// Desc:管理处名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string guanlichuname {get;set;}

           /// <summary>
           /// Desc:类型名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string property {get;set;}

           /// <summary>
           /// Desc:小区ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string xiaoquid {get;set;}

    }
}
