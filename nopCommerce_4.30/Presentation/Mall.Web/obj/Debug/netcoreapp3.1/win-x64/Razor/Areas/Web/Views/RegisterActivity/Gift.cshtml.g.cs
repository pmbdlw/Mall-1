#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\RegisterActivity\Gift.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ad00d289d3d10ee1008873d479e967d5fd3ce6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Web_Views_RegisterActivity_Gift), @"mvc.1.0.view", @"/Areas/Web/Views/RegisterActivity/Gift.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ad00d289d3d10ee1008873d479e967d5fd3ce6e", @"/Areas/Web/Views/RegisterActivity/Gift.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090c48694750ba7c62e752bf94ad67a159f3356f", @"/Areas/Web/Views/_ViewImports.cshtml")]
    public class Areas_Web_Views_RegisterActivity_Gift : Mall.Web.Framework.WebViewPage<Mall.DTO.CouponSendByRegisterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\RegisterActivity\Gift.cshtml"
  
    ViewBag.title = "注册有礼";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""/Areas/Web/Content/register-gift.css"">
<script src=""/Areas/Mobile/Templates/Default/Scripts/move.js""></script>
<div class=""rgift-container"">
    <div class=""bd"">
        <div class=""con"">
            <div class=""rgift-slider"">
                <div class=""rgift-slider-inner"">
                    <ul id=""J_slider_wrap"">
");
#nullable restore
#line 14 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\RegisterActivity\Gift.cshtml"
                         foreach (var item in Model.CouponIds)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <span>\r\n                                    <em>¥</em>\r\n                                    <strong>");
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\RegisterActivity\Gift.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                    <p>");
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\RegisterActivity\Gift.cshtml"
                                  Write(item.OrderAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </span>\r\n                            </li>\r\n");
#nullable restore
#line 23 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\RegisterActivity\Gift.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n                <div class=\"rgift-slider-nav\" id=\"J_slider_nav\"></div>\r\n            </div>\r\n            <a class=\"register-link\"");
            BeginWriteAttribute("href", " href=\"", 1063, "\"", 1125, 1);
#nullable restore
#line 29 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\RegisterActivity\Gift.cshtml"
WriteAttributeValue("", 1070, Url.Action("Index", "Register", new { type ="gift"}), 1070, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">领取 ");
#nullable restore
#line 29 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\RegisterActivity\Gift.cshtml"
                                                                                                  Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 元礼包</a>
        </div>
    </div>
    <div class=""ft"">
        <div class=""con"">
            <div class=""rule"">
                <h4><strong>活动规则:</strong></h4>
                <p><strong>1.活动期间，优惠券数量有限，发完为止；</strong></p>
                <p><strong>2.本活动为不定时开启，活动开启阶段，所有新注册的会员均能参加活动；</strong></p>
            </div>
            <div class=""weixin"">
                <img src=""/Areas/Web/Images/rgift-weixin.jpg"">
                <strong>扫码关注</strong>
                <p>Mall官方微信</p>
            </div>
        </div>
    </div>
</div>
<script>
    window.onload = function () {
        
        if (");
#nullable restore
#line 50 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\RegisterActivity\Gift.cshtml"
       Write(Model.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ==0||");
#nullable restore
#line 50 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\RegisterActivity\Gift.cshtml"
                          Write((int)Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ==0) {
            $.dialog.errorTips(""很抱歉！优惠券已被领完，请期待下次活动！"", function () {
                window.location.href=""/"";
            },3);
        }
        
        var oWrap = document.getElementById('J_slider_wrap');
        var oNav = document.getElementById('J_slider_nav');
        var aItem = oWrap.getElementsByTagName('li');
        var aSpan = oNav.getElementsByTagName('span');
        var num = 0; // 默认显示第几组，0为第一组
        var w = aItem[0].offsetWidth + 20;

        oWrap.style.width = aItem.length * w + 'px';
        oWrap.style.left = -num * w * 3 + 'px';

        // 每3个为一组生成一个圆点导航
        var oNavHtml = '';
        var oNavInt = parseInt(aItem.length / 3);
        if (aItem.length % 3 == 0) {
            for (var i = 0; i < oNavInt; i++) {
                oNavHtml += '<span></span>';
            }
        } else {
            for (var i = 0; i < oNavInt + 1; i++) {
                oNavHtml += '<span></span>';
            }
        }
        oNav.innerHTML = oNavHtml;

  ");
            WriteLiteral(@"      // 初始化
        function fnTab() {
            for (var i = 0; i < aSpan.length; i++) {
                aSpan[i].className = '';
            }
            aSpan[num].className = 'selected';
        }
        fnTab();

        // 点击滚动
        for (var i = 0; i < aSpan.length; i++) {
            aSpan[i].index = i;
            aSpan[i].onclick = function () {
                num = this.index;
                startMove(oWrap, { left: -num * w * 3 }, 400, 'easeOut');
                fnTab();
            }
        }
    }

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.DTO.CouponSendByRegisterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
