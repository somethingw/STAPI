using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Part")]
    public partial class Part
    {
           public Part(){


           }
           /// <summary>
           /// Desc:部位ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ptid {get;set;}

           /// <summary>
           /// Desc:部位名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:父部位ID
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? rootid {get;set;}

           /// <summary>
           /// Desc:分段显示
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? showtype {get;set;}

           /// <summary>
           /// Desc:是否显示
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? visible {get;set;}

    }
}
