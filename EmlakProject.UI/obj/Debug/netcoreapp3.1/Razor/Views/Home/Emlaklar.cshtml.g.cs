#pragma checksum "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7886c193640ca1a07084fdef8e0dd4349dce834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Emlaklar), @"mvc.1.0.view", @"/Views/Home/Emlaklar.cshtml")]
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
#line 1 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\_ViewImports.cshtml"
using EmlakProject.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\_ViewImports.cshtml"
using EmlakProject.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7886c193640ca1a07084fdef8e0dd4349dce834", @"/Views/Home/Emlaklar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71701b13cf808f43e6924a8e45940f84b4e7b758", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Emlaklar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmlakProject.Entities.EmlakBilgisi>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
  
    ViewData["Title"] = "Emlaklar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Emlaklar</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 11 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
Write(Html.ActionLink("Emlak Ekleme Sayfasına Git", "EmlakEkle"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
           Write(Html.DisplayNameFor(model => model.EmlakTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
           Write(Html.DisplayNameFor(model => model.MetreKare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
           Write(Html.DisplayNameFor(model => model.OdaSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
           Write(Html.DisplayNameFor(model => model.Kat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
           Write(Html.DisplayNameFor(model => model.BinaKati));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
           Write(Html.DisplayNameFor(model => model.Emlakci));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmlakTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
               Write(Html.DisplayFor(modelItem => item.MetreKare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
               Write(Html.DisplayFor(modelItem => item.OdaSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
               Write(Html.DisplayFor(modelItem => item.Kat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
               Write(Html.DisplayFor(modelItem => item.BinaKati));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
               Write(Html.DisplayFor(modelItem => item.Emlakci.EmlakciAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\Emlaklar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmlakProject.Entities.EmlakBilgisi>> Html { get; private set; }
    }
}
#pragma warning restore 1591