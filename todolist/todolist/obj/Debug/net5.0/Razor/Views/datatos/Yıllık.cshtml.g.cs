#pragma checksum "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dcf1ee2f5c20c356524ba0c173c4560057e8ae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_datatos_Yıllık), @"mvc.1.0.view", @"/Views/datatos/Yıllık.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dcf1ee2f5c20c356524ba0c173c4560057e8ae2", @"/Views/datatos/Yıllık.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea6fe19a32212eda3686924054d1465ed559315", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_datatos_Yıllık : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml"
  
    ViewData["Title"] = "Yıllık";
    Layout = "~/Views/Shared/_HomePageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h2>Yıllık Program</h2>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml"
 using (Html.BeginForm("Yıllık","datatos",FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Yıl giriniz: ");
#nullable restore
#line 12 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml"
                Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        <input type=\"submit\" value=\"Search\" /></p>\r\n");
#nullable restore
#line 14 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th> id </th>\r\n        <th> Yapılacaklar </th>\r\n        <th> Tarih </th>\r\n    </tr>\r\n");
#nullable restore
#line 22 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml"
     foreach (var x in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml"
       Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml"
       Write(x.Donote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml"
       Write(x.Datetime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a");
            BeginWriteAttribute("href", " href =\"", 613, "\"", 644, 2);
            WriteAttributeValue("", 621, "/datatos/KayitSil/", 621, 18, true);
#nullable restore
#line 28 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml"
WriteAttributeValue("", 639, x.Id, 639, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a> </td>\r\n        <td><a");
            BeginWriteAttribute("href", " href =\"", 698, "\"", 731, 2);
            WriteAttributeValue("", 706, "/datatos/KayitGetir/", 706, 20, true);
#nullable restore
#line 29 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml"
WriteAttributeValue("", 726, x.Id, 726, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a> </td>\r\n    </tr>\r\n");
#nullable restore
#line 31 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\Yıllık.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n</table>\r\n\r\n");
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
