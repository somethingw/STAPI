﻿using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace STAPI.model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Id2Auth")]
    public partial class Id2Auth
    {
           public Id2Auth(){


           }
           /// <summary>
           /// Desc:身份ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int idno {get;set;}

           /// <summary>
           /// Desc:权限ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int authid {get;set;}

    }
}
