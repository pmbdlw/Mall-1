#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47bd1e67778844634ae7bd19495334607bf6b198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Web_Views_Shared__UserCenterLeft), @"mvc.1.0.view", @"/Areas/Web/Views/Shared/_UserCenterLeft.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Web.Areas.SellerAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Web.Areas.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.CommonModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47bd1e67778844634ae7bd19495334607bf6b198", @"/Areas/Web/Views/Shared/_UserCenterLeft.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090c48694750ba7c62e752bf94ad67a159f3356f", @"/Areas/Web/Views/_ViewImports.cshtml")]
    public class Areas_Web_Views_Shared__UserCenterLeft : Mall.Web.Framework.WebViewPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--_UserCenterLeft start-->\r\n<div class=\"menu_left_box\">\r\n    <span class=\"a icon1\">个人中心</span>\r\n    <a class=\"b\"");
            BeginWriteAttribute("href", " href=\"", 114, "\"", 154, 1);
#nullable restore
#line 4 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml"
WriteAttributeValue("", 121, Url.Action("index","userCenter"), 121, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">我的个人中心</a>\r\n    <a class=\"b\"");
            BeginWriteAttribute("href", " href=\"", 184, "\"", 224, 1);
#nullable restore
#line 5 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml"
WriteAttributeValue("", 191, Url.Action("index", "UserOrder"), 191, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">我的订单</a>\r\n    <a class=\"b\"");
            BeginWriteAttribute("href", " href=\"", 252, "\"", 298, 1);
#nullable restore
#line 6 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml"
WriteAttributeValue("", 259, Url.Action("index","userConsultation"), 259, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">咨询管理</a>\r\n    <a class=\"b\"");
            BeginWriteAttribute("href", " href=\"", 326, "\"", 367, 1);
#nullable restore
#line 7 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml"
WriteAttributeValue("", 333, Url.Action("index","userComment"), 333, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">评价管理</a>\r\n    <span class=\"a icon2\">我的关注</span>\r\n    <a class=\"b\"");
            BeginWriteAttribute("href", " href=\"", 434, "\"", 479, 1);
#nullable restore
#line 9 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml"
WriteAttributeValue("", 441, Url.Action("index", "productConcern"), 441, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">商品关注</a>\r\n    <a class=\"b\"");
            BeginWriteAttribute("href", " href=\"", 507, "\"", 549, 1);
#nullable restore
#line 10 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml"
WriteAttributeValue("", 514, Url.Action("index", "shopConcern"), 514, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">店铺关注</a>\r\n    <span class=\"a icon3\">售后服务</span>\r\n    <a class=\"b\"");
            BeginWriteAttribute("href", " href=\"", 616, "\"", 658, 1);
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml"
WriteAttributeValue("", 623, Url.Action("index", "OrderRefund"), 623, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">退换货服务</a>\r\n    <a class=\"b\"");
            BeginWriteAttribute("href", " href=\"", 687, "\"", 732, 1);
#nullable restore
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml"
WriteAttributeValue("", 694, Url.Action("index", "OrderComplaint"), 694, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">投诉维权</a>\r\n    <span class=\"a icon4\">账户管理</span>\r\n    <a class=\"b\"");
            BeginWriteAttribute("href", " href=\"", 799, "\"", 840, 1);
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml"
WriteAttributeValue("", 806, Url.Action("index","userAddress"), 806, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">收货地址管理</a>\r\n    <a class=\"b\"");
            BeginWriteAttribute("href", " href=\"", 870, "\"", 908, 1);
#nullable restore
#line 16 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml"
WriteAttributeValue("", 877, Url.Action("index","userInfo"), 877, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">个人信息</a>\r\n    <a class=\"b\"");
            BeginWriteAttribute("href", " href=\"", 936, "\"", 985, 1);
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Shared\_UserCenterLeft.cshtml"
WriteAttributeValue("", 943, Url.Action("AccountSafety", "UserCenter"), 943, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">账户安全管理</a>\r\n</div>\r\n<!--_UserCenterLeft end-->");
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
