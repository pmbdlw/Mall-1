#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Site\Version.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd78ee076c74c314bea46f9dcb3735d7996ce0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Site_Version), @"mvc.1.0.view", @"/Views/Site/Version.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd78ee076c74c314bea46f9dcb3735d7996ce0a", @"/Views/Site/Version.cshtml")]
    public class Views_Site_Version : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Site\Version.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style type=""text/css"">
    body {
        background-color: #f2f2f2;
    }

    .error {
        background: url(/images/error.jpg) no-repeat center;
        padding: 300px 0;
        position: relative;
    }

        .error h3 {
            width: 350px;
            position: absolute;
            left: 50%;
            top: 260px;
            margin-left: -40px;
            font-family: 'microsoft yahei';
            font-weight: normal;
            line-height: 36px;
            color: #e3393c;
            font-size: 16px;
        }

            .error h3 span {
                color: #333;
            }
</style>
<div>
    产品名称：<span>Hishop-Mall</span><br />
    产品版本：<span>");
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Site\Version.cshtml"
          Write(ViewBag.FileVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n    部署类型：<span>");
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Site\Version.cshtml"
           Write(ViewBag.IsDebug?"Debug":"Release");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n");
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
