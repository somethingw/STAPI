using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace aliyun_api_gateway_sdk_ext.Model.tenacy
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("notice_title_img")]
    public partial class notice_title_img
    {
           public notice_title_img(){


           }
           /// <summary>
           /// Desc:文章封面图
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:文章ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? notice_ID {get;set;}

           /// <summary>
           /// Desc:图片路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string URL {get;set;}

    }
}
