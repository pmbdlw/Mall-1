#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ede0641373cd0fe77f1c99a1fbfec9f676d72223"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Console), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Console.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Mall.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Mall.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Mall.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Mall.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Mall.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Mall.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Mall.CommonModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ede0641373cd0fe77f1c99a1fbfec9f676d72223", @"/Areas/Admin/Views/Home/Console.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdcb39a21de2ae84fe919284139b99d5fdc20b3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Console : Mall.Web.Framework.WebViewPage<Mall.DTO.PlatConsoleModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script type=\"text/javascript\">\r\n$(function(){\r\n\tvar totalNum=\'");
#nullable restore
#line 4 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
             Write(Model.TodaySaleAmount.Value.ToString("f0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\tif(totalNum.length>6){\r\n\t\ttotalNum=totalNum.substring(0,totalNum.length-4);\r\n\t\t$(\'#totalNum\').html(totalNum+\'万\').attr(\'title\',\'");
#nullable restore
#line 7 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                                   Write(Model.TodaySaleAmount.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n\t}\r\n});\r\n</script>\r\n\r\n<div class=\"container\">\r\n    <ul class=\"console-total clearfix\">\r\n        <li class=\"fore1\">\r\n            <i></i>\r\n            <div>\r\n                <strong id=\"totalNum\">");
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                 Write(Model.TodaySaleAmount.Value.ToString("f0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                <span>今日有效销售总额</span>\r\n            </div>\r\n        </li>\r\n        <li class=\"fore2\">\r\n            <i></i>\r\n            <div>\r\n                <strong>");
#nullable restore
#line 24 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                   Write(Model.TodayMemberIncrease);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                <span>今日会员新增数</span>\r\n            </div>\r\n        </li>\r\n        <li class=\"fore3\">\r\n            <i></i>\r\n            <div>\r\n                <strong>");
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                   Write(Model.TodayShopIncrease);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                <span>今日店铺新增数</span>
            </div>
        </li>
    </ul>

    <div class=""ms-myorder modle-box"">
        <h3><span>商品</span><span>会员</span><span>交易</span><span>营销</span></h3>
        <div class=""mycollect cl"">
            <dl class=""clearfix"">
                <dt>待办事项</dt>
                <dd class=""first-child"">
                    <p><a href=""/admin/product/management?status=1"">商品待审核(");
#nullable restore
#line 43 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                                                     Write(Model.WaitForAuditingProducts);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></p>\r\n                    <p><a href=\"/admin/brand/verify\">品牌待审核(");
#nullable restore
#line 44 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                                      Write(Model.WaitForAuditingBrands);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></p>\r\n                </dd>\r\n                <dd class=\"two-child\">\r\n                    <p><a href=\"/admin/shop/management?type=Auditing&s=2\">入驻待审核(");
#nullable restore
#line 47 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                                                           Write(Model.WaitAuditShops);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>");
            WriteLiteral("</p>\r\n");
            WriteLiteral("                    <p><a href=\"/Admin/Capital/WithDraw?status=1&dispalyurl=/Admin/Capital/Index\">待处理提现(");
#nullable restore
#line 49 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                                                                                   Write(Model.Cash);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></p>\r\n                    <p><a href=\"/Admin/Gift/Order?status=2\">礼品待发货(");
#nullable restore
#line 50 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                                             Write(Model.GiftSend);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></p>\r\n                </dd>\r\n                <dd class=\"two-child\">\r\n                    <p><a href=\"/admin/OrderComplaint/management?status=3\">待仲裁(");
#nullable restore
#line 53 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                                                          Write(Model.Complaints);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></p>\r\n\t\t\t\t\t<p><a href=\"/Admin/OrderRefund/management?showtype=2&status=5\">待退款(");
#nullable restore
#line 54 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                                                                  Write(Model.RefundTrades);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></p>\r\n                    <p><a href=\"/Admin/OrderRefund/management?showtype=3&status=5\">待退货(");
#nullable restore
#line 55 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                                                                  Write(Model.OrderWithRefundAndRGoods);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></p>\r\n                </dd>\r\n                <dd class=\"two-child\">\r\n                    <p><a href=\"/admin/LimitTimeBuy/management?status=1\">待审核(");
#nullable restore
#line 58 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                                                        Write(Model.WaitForAuditingLimitTimeBuy);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</a></p>
                </dd>
            </dl>
        </div>
    </div>

    <div class=""console-detaile clearfix"">
        <div class=""item shop-item"">
            <div class=""item-inner"">
				<div class=""item-bt"">
                    <i></i>
                </div>
                <div class=""item-hd"">店铺（个）<p>");
#nullable restore
#line 70 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                        Write(Model.ShopNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                <div class=\"item-bd\">\r\n                    <p><em>");
#nullable restore
#line 72 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                      Write(Model.TodayShopIncrease);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>今日新增</p>\r\n                    <p><em>");
#nullable restore
#line 73 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                      Write(Model.YesterdayShopIncrease);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>昨日新增</p>\r\n                    <p><em>");
#nullable restore
#line 74 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                      Write(Model.WaitAuditShops);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>待审核</p>\r\n                    <p><em>");
#nullable restore
#line 75 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                      Write(Model.ExpiredShops);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>店铺到期</p>\r\n                    <p><em><a");
            BeginWriteAttribute("href", " href=\"", 3318, "\"", 3407, 2);
#nullable restore
#line 76 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
WriteAttributeValue("", 3325, Url.Action("Management","ShopWithDraw"), 3325, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3365, "?displayUrl=/Admin/ShopWithDraw/Management", 3365, 42, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"color-f\">");
#nullable restore
#line 76 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                                                                                                                   Write(Model.ShopCashNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></em>待处理提现</p>
                </div>
            </div>
        </div>
        <div class=""item goods-item"">
            <div class=""item-inner"">
				<div class=""item-bt"">
                    <i></i>
                </div>
                <div class=""item-hd"">商品（件）<p>");
#nullable restore
#line 85 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                        Write(Model.ProductNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                <div class=\"item-bd\">\r\n                    <p><em>");
#nullable restore
#line 87 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                      Write(Model.OnSaleProducts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>出售中</p>\r\n                    <p><em>");
#nullable restore
#line 88 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                      Write(Model.WaitForAuditingProducts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>待审核</p>\r\n                    <p><em>");
#nullable restore
#line 89 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                      Write(Model.ProductConsultations);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>商品咨询</p>\r\n                    <p><em>");
#nullable restore
#line 90 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                      Write(Model.ProductComments);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</em>商品评价</p>
                    <p>&nbsp;</p>
                </div>
                
            </div>
        </div>
        <div class=""item order-item"">
            <div class=""item-inner"">
				<div class=""item-bt"">
                    <i></i>
                </div>
                <div class=""item-hd"">交易（笔）<p>");
#nullable restore
#line 101 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                                        Write(Model.OrderCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n                <div class=\"item-bd\">\r\n                    <p><em>");
#nullable restore
#line 103 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                      Write(Model.WaitPayTrades);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>待付款</p>\r\n                    <p><em>");
#nullable restore
#line 104 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Home\Console.cshtml"
                      Write(Model.WaitDeliveryTrades);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>待发货</p>\r\n");
            WriteLiteral("                    <p>&nbsp;</p>\r\n                </div>\r\n                \r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.DTO.PlatConsoleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
