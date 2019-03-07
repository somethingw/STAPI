using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("inspstateid2name")]
    public partial class inspstateid2name
    {
           public inspstateid2name(){


           }
           /// <summary>
           /// Desc:巡检状态表 巡检状态id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int inspestateid {get;set;}

           /// <summary>
           /// Desc:巡检状态名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string inspestatename {get;set;}

    }
}
