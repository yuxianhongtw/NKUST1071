#pragma checksum "D:\[高科大]軟體工程\github\1207\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "742b935ccef72ef60091b7f189902284efbee9d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OpenData_Index), @"mvc.1.0.view", @"/Views/OpenData/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OpenData/Index.cshtml", typeof(AspNetCore.Views_OpenData_Index))]
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
#line 1 "D:\[高科大]軟體工程\github\1207\OpenDataImport\YX.Web\Views\_ViewImports.cshtml"
using YX.Web;

#line default
#line hidden
#line 2 "D:\[高科大]軟體工程\github\1207\OpenDataImport\YX.Web\Views\_ViewImports.cshtml"
using YX.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742b935ccef72ef60091b7f189902284efbee9d6", @"/Views/OpenData/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c28acb29a96a6decfca5f00132402a18b82d3ad5", @"/Views/_ViewImports.cshtml")]
    public class Views_OpenData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<YX.Core.Models.OpenData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\[高科大]軟體工程\github\1207\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(79, 217, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>服務分類</th>\r\n            <th>資料集名稱</th>\r\n            <th>詳細</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 18 "D:\[高科大]軟體工程\github\1207\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(345, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(376, 7, false);
#line 21 "D:\[高科大]軟體工程\github\1207\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
           Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(383, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(407, 9, false);
#line 22 "D:\[高科大]軟體工程\github\1207\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
           Write(item.服務分類);

#line default
#line hidden
            EndContext();
            BeginContext(416, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(440, 10, false);
#line 23 "D:\[高科大]軟體工程\github\1207\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
           Write(item.資料集名稱);

#line default
#line hidden
            EndContext();
            BeginContext(450, 67, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 517, "\"", 549, 2);
            WriteAttributeValue("", 524, "/OpenData/Detail/", 524, 17, true);
#line 25 "D:\[高科大]軟體工程\github\1207\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
WriteAttributeValue("", 541, item.id, 541, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(550, 48, true);
            WriteLiteral(">連結</a>\r\n                <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 598, "\"", 628, 2);
            WriteAttributeValue("", 605, "/OpenData/Edit/", 605, 15, true);
#line 26 "D:\[高科大]軟體工程\github\1207\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
WriteAttributeValue("", 620, item.id, 620, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(629, 43, true);
            WriteLiteral(">編輯</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "D:\[高科大]軟體工程\github\1207\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(683, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<YX.Core.Models.OpenData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
