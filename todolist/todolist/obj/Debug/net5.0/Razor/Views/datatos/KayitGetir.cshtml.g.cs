#pragma checksum "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\KayitGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2839fe28b5b499af49661b2dcbd215ea5b472ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_datatos_KayitGetir), @"mvc.1.0.view", @"/Views/datatos/KayitGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2839fe28b5b499af49661b2dcbd215ea5b472ef", @"/Views/datatos/KayitGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea6fe19a32212eda3686924054d1465ed559315", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_datatos_KayitGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<todolist.Models.datatodo>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\KayitGetir.cshtml"
  
    ViewData["Title"] = "KayitGetir";
    Layout = "~/Views/Shared/_HomePageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\KayitGetir.cshtml"
 using (Html.BeginForm("KayitGüncelle", "datatos", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("     <b>Id</b>\r\n    <br />\r\n");
#nullable restore
#line 11 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\KayitGetir.cshtml"
Write(Html.TextAreaFor(x=>x.Id, new {@class= "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Görev</b>\r\n    <br />\r\n");
#nullable restore
#line 15 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\KayitGetir.cshtml"
Write(Html.TextAreaFor(x=>x.Donote, new {@class= "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Tarih</b>\r\n    <br />\r\n");
#nullable restore
#line 19 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\KayitGetir.cshtml"
Write(Html.EditorFor(x => x.Datetime, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n  $( function() {\r\n      $(\"#Date\").datepicker({ dateFormat:\"dd / mm / yy\"});\r\n  } );\r\n</script>\r\n    <br />\r\n    <button class=\"btn btn-info\">Güncelle</button>\r\n");
#nullable restore
#line 27 "C:\Users\pelii\source\repos\todolist\todolist\Views\datatos\KayitGetir.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<todolist.Models.datatodo> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
