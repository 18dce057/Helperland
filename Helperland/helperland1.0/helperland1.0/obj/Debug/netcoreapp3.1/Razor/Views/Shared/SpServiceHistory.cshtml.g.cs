#pragma checksum "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\Shared\SpServiceHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4c629e855141985c13471c8bf2f199a046b05cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SpServiceHistory), @"mvc.1.0.view", @"/Views/Shared/SpServiceHistory.cshtml")]
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
#line 1 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\_ViewImports.cshtml"
using helperland1._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Shraddha\Helperland\Helperland\helperland1.0\helperland1.0\Views\_ViewImports.cshtml"
using helperland1._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c629e855141985c13471c8bf2f199a046b05cc", @"/Views/Shared/SpServiceHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf1df5a63102c4cf8f6f3232c926fcf06626c10", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SpServiceHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""ServiceHistory"" class=""tab-contant"">

    <div class=""d-flex justify-content-between"">
            <p class=""alignleft""> Service History </p>
            <button id=""export"" class=""ServiceHistroyExport"">Export</button>
        </div>
  
    <table id=""SPServiceHistoryTable"" class=""table"">
        <thead class=""table-light"">
            <tr style=""text-align:center"">
                <th scope=""col"" style=""width:20%;"">Service ID <img src=""/image/sort.png"" alt=""...""></th>
                <th scope=""col"" style=""width:30%"">Service date <img src=""/image/sort.png"" alt=""...""></th>
                <th scope=""col"" style=""width:50%"">Customers details <img src=""/image/sort.png"" alt=""...""></th>

            </tr>
        </thead>
        <tbody id=""ServiceHistoryTbody"">
            <tr data-value=""1"">
                <td data-label=""Service ID"">
                    <p class=""margin"">323436</p>
                </td>
                <td data-label=""Service date"">
                    <div>
                        <i");
            WriteLiteral(@"mg src=""/image/calendar2.png"" alt=""calender""> 09/04/2018
                    </div>
                    <img src=""/image/layer-14.png"" alt=""clock""> 12:00-18:00
                </td>
                <td class=""text-start"" data-lable=""Customer Details"">
                    <div class=""ms-4"">David Bough</div>
                    <div class=""d-flex"">
                        <span><img class=""me-0"" src=""/image/layer-15.png""");
            BeginWriteAttribute("alt", " alt=\"", 1446, "\"", 1452, 0);
            EndWriteAttribute();
            WriteLiteral("></span> <span>\n                            musterstrabe 5,12345\n                            Bonn\n                        </span>\n                    </div>\n                </td>\n\n            </tr>\n        </tbody>\n    </table>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591