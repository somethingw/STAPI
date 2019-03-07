using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("PartType")]
    public partial class PartType
    {
           public PartType(){


           }
           /// <summary>
           /// Desc:部位类型ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int pttpid {get;set;}

           /// <summary>
           /// Desc:部位类型名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:房屋类型ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? hsstid {get;set;}

           /// <summary>
           /// Desc:过程ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? processid {get;set;}

    }
}
