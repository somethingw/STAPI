using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace STAPI.model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sysinfo")]
    public partial class sysinfo
    {
           public sysinfo(){


           }
           /// <summary>
           /// Desc:参数ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string paraid {get;set;}

           /// <summary>
           /// Desc:参数名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:参数值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string value {get;set;}

    }
}
