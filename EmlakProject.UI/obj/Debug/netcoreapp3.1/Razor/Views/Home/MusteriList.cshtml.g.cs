#pragma checksum "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a64742779c595330998cf6ddac599bf83788257"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MusteriList), @"mvc.1.0.view", @"/Views/Home/MusteriList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a64742779c595330998cf6ddac599bf83788257", @"/Views/Home/MusteriList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71701b13cf808f43e6924a8e45940f84b4e7b758", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MusteriList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmlakProject.Entities.Musteri>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
  
    ViewData["Title"] = "MusteriList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MusteriList</h1>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 11 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
Write(Html.ActionLink("M????teri Ekleme Sayfas??na Git", "AddMusteri"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
           Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
           Write(Html.DisplayNameFor(model => model.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
           Write(Html.DisplayNameFor(model => model.EvTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
           Write(Html.DisplayNameFor(model => model.CepTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Emlak????\r\n            </th>\r\n\r\n            <th>Emlak Ara</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
               Write(Html.DisplayFor(modelItem => item.EvTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
               Write(Html.DisplayFor(modelItem => item.CepTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Emlakci.EmlakciAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1695, "\"", 1746, 2);
            WriteAttributeValue("", 1702, "/Home/GetEmlakciID?emlakciId=", 1702, 29, true);
#nullable restore
#line 62 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
WriteAttributeValue("", 1731, item.EmlakciId, 1731, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Emlak Ara</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\MusteriList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
       
        $("".btnEmlakAra"").click(function () {
            var emlakciId = $(this).attr(""dataID"");
            $.ajax({
                url: ""/Home/GetEmlakciID/"" + emlakciId,
                type: ""GET"",
                success: function (resp) {
                    if (resp != null) {
                        console.log(""resp"",resp)
                    }
                },
                onerror: function (err) {
                    alert(""Hata Olu??tu."")
                    console.log(err);
                }
            })
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmlakProject.Entities.Musteri>> Html { get; private set; }
    }
}
#pragma warning restore 1591
