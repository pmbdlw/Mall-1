#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "748b6745675ff6aec112a0f3393b398b867eb84e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Web_Views_Side_MyAsset), @"mvc.1.0.view", @"/Areas/Web/Views/Side/MyAsset.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"748b6745675ff6aec112a0f3393b398b867eb84e", @"/Areas/Web/Views/Side/MyAsset.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090c48694750ba7c62e752bf94ad67a159f3356f", @"/Areas/Web/Views/_ViewImports.cshtml")]
    public class Areas_Web_Views_Side_MyAsset : Mall.Web.Framework.WebViewPage<Mall.Web.Areas.Web.Models.MyAssetViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"side-asset-total cl\">\r\n    <div>\r\n        <span>");
#nullable restore
#line 8 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
          Write(Model.MyMemberIntegral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <p>我的积分</p>\r\n    </div>\r\n    <div>\r\n        <span>");
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
          Write(Model.MyCouponCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <p>优惠券</p>\r\n    </div>\r\n</div>\r\n<div class=\"side-asset-list\">\r\n    <p>已领取的优惠券</p>\r\n    <ul>\r\n");
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
          var cls = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
         foreach (var item in Model.MyCoupons)
        {
            if (item.Price >= 100) { cls = "coupon-lg"; }

            else if (item.Price <= 50) { cls = "coupon-sm"; }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 588, "\"", 600, 1);
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
WriteAttributeValue("", 596, cls, 596, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 622, "\"", 652, 2);
            WriteAttributeValue("", 629, "/Shop/Home/", 629, 11, true);
#nullable restore
#line 26 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
WriteAttributeValue("", 640, item.ShopId, 640, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                    <h5>");
#nullable restore
#line 27 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                   Write(item.ShopName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 28 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                     if (item.OrderAmount > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3><span>￥");
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>满");
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                                                   Write(item.OrderAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("使用</h3>\r\n");
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3><span>￥");
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>无门槛(不含运费)</h3>\r\n");
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                     if (item.UseArea == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 38 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                       Write(item.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>截止：");
#nullable restore
#line 40 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                     Write(item.EndTime.ToString("yyyy.MM.dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 43 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
          cls = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
         foreach (var item in Model.MyShopBonus)
        {
            if (item.Receive.Price >= 100) { cls = "coupon-lg"; }

            else if (item.Receive.Price <= 50) { cls = "coupon-sm"; }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 1449, "\"", 1461, 1);
#nullable restore
#line 51 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
WriteAttributeValue("", 1457, cls, 1457, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1483, "\"", 1514, 2);
            WriteAttributeValue("", 1490, "/Shop/Home/", 1490, 11, true);
#nullable restore
#line 52 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
WriteAttributeValue("", 1501, item.Shop.Id, 1501, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                    <h5>");
#nullable restore
#line 53 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                   Write(item.Shop.ShopName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 54 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                     if (item.Bonus.UseState == Mall.Entities.ShopBonusInfo.UseStateType.FilledSend)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3><span>￥");
#nullable restore
#line 56 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                              Write(item.Receive.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>满");
#nullable restore
#line 56 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                                                           Write(item.Bonus.UsrStatePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("减");
#nullable restore
#line 56 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                                                                                        Write(item.Receive.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("优惠券</h3>\r\n");
#nullable restore
#line 57 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3><span>￥");
#nullable restore
#line 60 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
              Write(item.Receive.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>无门槛(不含运费)</h3>\r\n");
#nullable restore
#line 61 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>有效期：");
#nullable restore
#line 62 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
                      Write(item.Bonus.BonusDateEnd.ToString("yyyy.MM.dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 65 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Side\MyAsset.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.Web.Areas.Web.Models.MyAssetViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
