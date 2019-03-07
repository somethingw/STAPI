using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("CRSource")]
    public partial class CRSource
    {
           public CRSource(){


           }
           /// <summary>
           /// Desc:报修来源ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int sourceid {get;set;}

           /// <summary>
           /// Desc:报修来源名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:报修来源类型
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int sourcetype {get;set;}

    }
}
