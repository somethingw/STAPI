using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("HouseState")]
    public partial class HouseState
    {
           public HouseState(){


           }
           /// <summary>
           /// Desc:房屋类型ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int hsstid {get;set;}

           /// <summary>
           /// Desc:房屋类型名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

    }
}
