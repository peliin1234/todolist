#pragma checksum "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1443ff666671047d4047a64c3f993b0dc276800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_datatos_Index), @"mvc.1.0.view", @"/Views/datatos/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pelii\source\repos\todolist\todolist\Views\_ViewImports.cshtml"
using todolist;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pelii\source\repos\todolist\todolist\Views\_ViewImports.cshtml"
using todolist.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1443ff666671047d4047a64c3f993b0dc276800", @"/Views/datatos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea6fe19a32212eda3686924054d1465ed559315", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_datatos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_HomePageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2>Tüm Kayıtlar</h2>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th> id </th>\r\n        <th> Yapılacaklar </th>\r\n        <th> Tarih </th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Index.cshtml"
     foreach (var x in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Index.cshtml"
       Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Index.cshtml"
       Write(x.Donote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Index.cshtml"
       Write(x.Datetime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a");
            BeginWriteAttribute("href", " href =\"", 423, "\"", 454, 2);
            WriteAttributeValue("", 431, "/datatos/KayitSil/", 431, 18, true);
#nullable restore
#line 22 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Index.cshtml"
WriteAttributeValue("", 449, x.Id, 449, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a> </td>\r\n        <td><a");
            BeginWriteAttribute("href", " href =\"", 508, "\"", 541, 2);
            WriteAttributeValue("", 516, "/datatos/KayitGetir/", 516, 20, true);
#nullable restore
#line 23 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Index.cshtml"
WriteAttributeValue("", 536, x.Id, 536, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a> </td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 26 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Index.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591