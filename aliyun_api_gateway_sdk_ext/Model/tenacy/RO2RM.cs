using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("RO2RM")]
    public partial class RO2RM
    {
           public RO2RM(){


           }
           /// <summary>
           /// Desc:维修单ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int roid {get;set;}

           /// <summary>
           /// Desc:维修员ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int rmid {get;set;}

           /// <summary>
           /// Desc:是否接单
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? cando {get;set;}

    }
}
