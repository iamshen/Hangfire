﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class PerPageSelector : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");


WriteLiteral("<div class=\"btn-toolbar btn-toolbar-top\">\r\n    <div class=\"btn-group pull-right p" +
"aginator\">\r\n");


            
            #line 5 "..\..\Pages\_PerPageSelector.cshtml"
         foreach (var count in new[] { 10, 20, 50, 100 })
        {

            
            #line default
            #line hidden
WriteLiteral("            <a class=\"btn btn-sm btn-default ");


            
            #line 7 "..\..\Pages\_PerPageSelector.cshtml"
                                         Write(count == _pager.PerPage ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \r\n                   href=\"");


            
            #line 8 "..\..\Pages\_PerPageSelector.cshtml"
                    Write(_pager.PerPageLink(count));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 8 "..\..\Pages\_PerPageSelector.cshtml"
                                                Write(count);

            
            #line default
            #line hidden
WriteLiteral("</a>    \r\n");


            
            #line 9 "..\..\Pages\_PerPageSelector.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <div class=\"btn-toolbar-spacer pull-right\"></div>\r\n    <div class" +
"=\"btn-toolbar-label btn-toolbar-label-sm pull-right\">\r\n        Jobs per page:\r\n " +
"   </div>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
