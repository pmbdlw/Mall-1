#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\Pay\CapitalChargeReturn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c16589a1a1abf2bd5d06b5574f50579e28cd7b62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SellerAdmin_Views_Pay_CapitalChargeReturn), @"mvc.1.0.view", @"/Areas/SellerAdmin/Views/Pay/CapitalChargeReturn.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 10 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Mall.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Mall.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Mall.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Mall.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Mall.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Mall.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Mall.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Mall.Web.Areas.SellerAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Mall.Web.Areas.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\_ViewImports.cshtml"
using Mall.CommonModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c16589a1a1abf2bd5d06b5574f50579e28cd7b62", @"/Areas/SellerAdmin/Views/Pay/CapitalChargeReturn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5955669422911a11135b862f296047894c21785d", @"/Areas/SellerAdmin/Views/_ViewImports.cshtml")]
    public class Areas_SellerAdmin_Views_Pay_CapitalChargeReturn : Mall.Web.Framework.WebViewPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\Pay\CapitalChargeReturn.cshtml"
  
    ViewBag.Title = "充值支付结果";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    // JavaScript source code
    $(function () {
        $('.progress-').hide();
    })

    var secs = 5; //倒计时的秒数
    var URL;
    function Load(url) {
        URL = url;
        for (var i = secs; i >= 0; i--) {
            window.setTimeout('doUpdate(' + i + ')', (secs - i) * 1000);
        }
    }

    function doUpdate(num) {
        document.getElementById(""ShowDiv"").innerHTML = '将在<strong><font color=red> ' + num + ' </font></strong>'+$(""#HRhp"").val()+'，请稍候...';
        if (num == 0) { window.location = URL; }
    }
    $(function () {
        Load(""/selleradmin"");
    })

</script>

<div class=""w Sclear-L"">
");
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\Pay\CapitalChargeReturn.cshtml"
      
        var errorMsg = ViewBag.Error;
        var flag = !string.IsNullOrWhiteSpace(errorMsg) ? "fail" : "success";
        var redirectUrl = string.IsNullOrWhiteSpace(errorMsg) ? ("/selleradmin") : "/";
        var htmlPart = string.IsNullOrWhiteSpace(errorMsg) ? ("秒后自动跳至充值页面<a  href='/selleradmin' class='link_1'>管理后台</a>") : "";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 1062, "\"", 1094, 4);
            WriteAttributeValue("", 1070, "tips-page", 1070, 9, true);
            WriteAttributeValue(" ", 1079, "pay-", 1080, 5, true);
#nullable restore
#line 38 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\Pay\CapitalChargeReturn.cshtml"
WriteAttributeValue("", 1084, flag, 1084, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1089, "-page", 1089, 5, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"height:400px;width:1000px;\">\r\n");
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\Pay\CapitalChargeReturn.cshtml"
         if (string.IsNullOrWhiteSpace(errorMsg))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>\r\n                恭喜您，支付成功！\r\n            </h2>\r\n");
#nullable restore
#line 44 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\Pay\CapitalChargeReturn.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>\r\n                抱歉，支付失败！请重新支付！\r\n            </h2>\r\n            <div class=\"error_child\">您可以：<a href=\"/selleradmin?url=/SellerAdmin/UserAccount/CapitalCharge\">返回保证金支付页面</a></div>\r\n");
#nullable restore
#line 51 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\Pay\CapitalChargeReturn.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div id=\"ShowDiv\"></div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1583, "\"", 1610, 1);
#nullable restore
#line 58 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\Pay\CapitalChargeReturn.cshtml"
WriteAttributeValue("", 1591, Html.Raw(htmlPart), 1591, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"HRhp\"/>\r\n");
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
