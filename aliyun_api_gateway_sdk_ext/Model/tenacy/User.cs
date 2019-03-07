using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("User")]
    public partial class User
    {
           public User(){


           }
           /// <summary>
           /// Desc:用户或组织ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int userid {get;set;}

           /// <summary>
           /// Desc:用户或组织名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:联系地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string address {get;set;}

           /// <summary>
           /// Desc:联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string contacts {get;set;}

           /// <summary>
           /// Desc:联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string tel {get;set;}

           /// <summary>
           /// Desc:性别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sex {get;set;}

           /// <summary>
           /// Desc:对象类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? usrtpid {get;set;}

           /// <summary>
           /// Desc:父对象ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? superior {get;set;}

           /// <summary>
           /// Desc:是否组织
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? iszhi {get;set;}

    }
}
