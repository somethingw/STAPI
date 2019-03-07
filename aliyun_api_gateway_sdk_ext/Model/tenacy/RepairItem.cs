using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("RepairItem")]
    public partial class RepairItem
    {
           public RepairItem(){


           }
           /// <summary>
           /// Desc:维修项目ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ritemid {get;set;}

           /// <summary>
           /// Desc:维修项目名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

    }
}
