﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryViews.Views.Account
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.4.1.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Profile.cshtml")]
    public class Profile : System.Web.Mvc.WebViewPage<login.Models.CustomProfileViewModel>
    {
        public Profile()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


            
            #line 3 "..\..\Views\Account\Profile.cshtml"
  
    ViewBag.Title = "Editar Profile";


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"formulari\">\r\n");


            
            #line 8 "..\..\Views\Account\Profile.cshtml"
 using (Html.BeginForm()) {
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Account\Profile.cshtml"
Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Account\Profile.cshtml"
                             


            
            #line default
            #line hidden
WriteLiteral("    <fieldset style=\"width:99%;\">\r\n        <legend>Dades personals</legend>\r\n    " +
"    <div class=\"fila\"> \r\n            <div class=\"columna\" style=\"width:300px;\">\r" +
"\n                    <div class=\"cella\" style=\"width:300px;\">\r\n                 " +
"           ");


            
            #line 16 "..\..\Views\Account\Profile.cshtml"
                       Write(Html.Label("Nom"));

            
            #line default
            #line hidden
WriteLiteral("                \r\n                            ");


            
            #line 17 "..\..\Views\Account\Profile.cshtml"
                       Write(Html.TextBoxFor(m => m.Nom));

            
            #line default
            #line hidden
WriteLiteral("      \r\n                    </div>\r\n                    <div class=\"cella\" style=" +
"\"width:300px;\"> \r\n                            ");


            
            #line 20 "..\..\Views\Account\Profile.cshtml"
                       Write(Html.Label("Primer Cognom"));

            
            #line default
            #line hidden
WriteLiteral("                \r\n                            ");


            
            #line 21 "..\..\Views\Account\Profile.cshtml"
                       Write(Html.TextBoxFor(m => m.PCognom));

            
            #line default
            #line hidden
WriteLiteral("    \r\n                    </div>\r\n                    <div class=\"cella\" style=\"w" +
"idth:300px;\">\r\n                            ");


            
            #line 24 "..\..\Views\Account\Profile.cshtml"
                       Write(Html.Label("Segon Cognom"));

            
            #line default
            #line hidden
WriteLiteral("             \r\n                            ");


            
            #line 25 "..\..\Views\Account\Profile.cshtml"
                       Write(Html.TextBoxFor(m => m.SCognom));

            
            #line default
            #line hidden
WriteLiteral(@"    
                    </div>            
            </div>
        </div>

        <div class=""fila"">
            <div class=""columna"">
                <div class=""buto"">
                    <input type=""submit"" value=""Modificar"" />    
                </div>
            </div>
        </div>

    </fieldset>
");


            
            #line 39 "..\..\Views\Account\Profile.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</div> \r\n\r\n");


DefineSection("Scripts", () => {

WriteLiteral("\r\n    ");


            
            #line 43 "..\..\Views\Account\Profile.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("Opcions", () => {

WriteLiteral("\r\n    <ul class=\"menuopt\">\r\n        <span>Opcions</span>\r\n        <li><a href=\"/l" +
"ogin/Account/Profile\">Modificar dades personals</a></li>\r\n        <li><a href=\"/" +
"login/Account/ChangePassword\">Canviar contrasenya</a></li>\r\n    </ul>\r\n");


});

WriteLiteral("\r\n\r\n\r\n\r\n");


        }
    }
}
#pragma warning restore 1591
