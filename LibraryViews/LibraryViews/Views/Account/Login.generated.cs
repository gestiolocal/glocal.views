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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Login.cshtml")]
    public class Login : System.Web.Mvc.WebViewPage<login.Models.LoginModel>
    {
        public Login()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


            
            #line 3 "..\..\Views\Account\Login.cshtml"
  
    ViewBag.Title = "         Identificació d'usuaris";


            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n\r\n<div style=\"width:100%;\">\r\n<div style=\"  min-width:35%; float:left; \"><p>" +
"</p></div>\r\n\r\n\r\n\r\n<div style=\"float:left; margin-top:200px;\">\r\n\r\n\r\n");


            
            #line 18 "..\..\Views\Account\Login.cshtml"
 using (Html.BeginForm(new { ReturnUrl = ViewBag.ReturnUrl })) {



            
            #line default
            #line hidden
WriteLiteral("    <fieldset style=\"width:300px;\">\r\n        <legend>Autenticació d\'usuaris</lege" +
"nd>\r\n        <ol>\r\n            <li style=\" margin-left:25px; width:250px;\">\r\n   " +
"             ");


            
            #line 25 "..\..\Views\Account\Login.cshtml"
           Write(Html.Label("Usuari"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                ");


            
            #line 26 "..\..\Views\Account\Login.cshtml"
           Write(Html.TextBoxFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li style=\" margin-left:25px; width:250px;\">\r\n  " +
"              ");


            
            #line 29 "..\..\Views\Account\Login.cshtml"
           Write(Html.Label("Contrasenya"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                ");


            
            #line 30 "..\..\Views\Account\Login.cshtml"
           Write(Html.PasswordFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n        </ol>\r\n        <input type=\"submit\" value=\"Iniciar s" +
"essió\" style=\" margin-left:25px; margin-bottom:25px;\" />\r\n    </fieldset>\r\n");


            
            #line 35 "..\..\Views\Account\Login.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Account\Login.cshtml"
Write(Html.ValidationSummary(true, "No ha estat possible la autenticació. "));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Account\Login.cshtml"
                                                                            
}

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n</div>\r\n\r\n");


DefineSection("Scripts", () => {

WriteLiteral("\r\n    ");


            
            #line 42 "..\..\Views\Account\Login.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


});

WriteLiteral("\r\n");


        }
    }
}
#pragma warning restore 1591
