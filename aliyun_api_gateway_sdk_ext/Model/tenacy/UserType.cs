using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("UserType")]
    public partial class UserType
    {
           public UserType(){


           }
           /// <summary>
           /// Desc:对象类型ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int tpid {get;set;}

           /// <summary>
           /// Desc:对象类型名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string usertype {get;set;}

    }
}
