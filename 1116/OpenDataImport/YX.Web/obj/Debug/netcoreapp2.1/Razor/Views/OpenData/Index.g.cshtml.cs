#pragma checksum "D:\[高科大]軟體工程\github\1116\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ef82383d7ab822fe0fd9db5fae8076d4b7771c"
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
#line 1 "D:\[高科大]軟體工程\github\1116\OpenDataImport\YX.Web\Views\_ViewImports.cshtml"
using YX.Web;

#line default
#line hidden
#line 2 "D:\[高科大]軟體工程\github\1116\OpenDataImport\YX.Web\Views\_ViewImports.cshtml"
using YX.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09ef82383d7ab822fe0fd9db5fae8076d4b7771c", @"/Views/OpenData/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c28acb29a96a6decfca5f00132402a18b82d3ad5", @"/Views/_ViewImports.cshtml")]
    public class Views_OpenData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<YX.Core.Models.OpenData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\[高科大]軟體工程\github\1116\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(79, 174, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>服務分類</th>\r\n            <th>資料集名稱</th>       \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 16 "D:\[高科大]軟體工程\github\1116\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(302, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(341, 9, false);
#line 19 "D:\[高科大]軟體工程\github\1116\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
               Write(item.服務分類);

#line default
#line hidden
            EndContext();
            BeginContext(350, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(378, 10, false);
#line 20 "D:\[高科大]軟體工程\github\1116\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
               Write(item.資料集名稱);

#line default
#line hidden
            EndContext();
            BeginContext(388, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 22 "D:\[高科大]軟體工程\github\1116\OpenDataImport\YX.Web\Views\OpenData\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(425, 22, true);
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