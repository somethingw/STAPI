using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("CtrlType")]
    public partial class CtrlType
    {
           public CtrlType(){


           }
           /// <summary>
           /// Desc:控制类型ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ctrltpid {get;set;}

           /// <summary>
           /// Desc:控制类型名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string controltype {get;set;}

    }
}
