#pragma checksum "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aa8d5863f24644ef583b0868f802aabd06c283c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetEmlakciID), @"mvc.1.0.view", @"/Views/Home/GetEmlakciID.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa8d5863f24644ef583b0868f802aabd06c283c", @"/Views/Home/GetEmlakciID.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71701b13cf808f43e6924a8e45940f84b4e7b758", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetEmlakciID : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmlakProject.Entities.EmlakBilgisi>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
  
    ViewData["Title"] = "GetEmlakciID";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Emlak Ara</h1>\r\n");
#nullable restore
#line 9 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
 using (Html.BeginForm("GetEmlakciID", "Home", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
     if (ViewBag.CountZero != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"margin-left:15px;color:red\">");
#nullable restore
#line 13 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
                                         Write(ViewBag.CountZero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"" style=""margin-left:15px;"">


        <div class=""col-md-3"">

            <input class=""metrekare"" name=""metrekare"" placeholder=""Metrekare girin "" required />*
        </div>
        <div class=""col-md-3"">

            <input type=""number"" class=""oda"" name=""oda"" placeholder=""Oda say??s?? girin "" required />*
        </div>
        <div class=""col-md-3"">
            <button class=""btn btn-success btnAra"" name=""btnAra"" style=""width:50px;height:40px;"">Ara</button>
        </div>
        <div class=""col-md-3"">
            ");
#nullable restore
#line 31 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
       Write(Html.ActionLink("??ndir", "DownloadExcel", new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
               Write(Html.DisplayNameFor(model => model.EmlakTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
               Write(Html.DisplayNameFor(model => model.MetreKare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
               Write(Html.DisplayNameFor(model => model.OdaSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 49 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
               Write(Html.DisplayNameFor(model => model.Kat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 52 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
               Write(Html.DisplayNameFor(model => model.BinaKati));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EmlakTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MetreKare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OdaSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Kat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BinaKati));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 80 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 83 "C:\Users\ozlem\source\repos\Emlak\EmlakProject\EmlakProject.UI\Views\Home\GetEmlakciID.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

        $("".btnAra"").click(function () {
            var deger = {
                ""OdaSayisi"": $("".oda"").val(),
                ""MetreKare"": $("".metrekare"").val
            }
            $.ajax({
                url: ""/Home/GetEmlakciID/"",
                type: ""POST"",
                data: deger,
                success: function (resp) {
                    if (resp != null) {
                        console.log(""resp"", resp)
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmlakProject.Entities.EmlakBilgisi>> Html { get; private set; }
    }
}
#pragma warning restore 1591
