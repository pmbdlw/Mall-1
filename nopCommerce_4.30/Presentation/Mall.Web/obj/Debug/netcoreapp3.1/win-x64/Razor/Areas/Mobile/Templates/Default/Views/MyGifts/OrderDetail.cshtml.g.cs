#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf0980c3e78f0955fb27d457333db7afd6d734d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mobile_Templates_Default_Views_MyGifts_OrderDetail), @"mvc.1.0.view", @"/Areas/Mobile/Templates/Default/Views/MyGifts/OrderDetail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 10 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.CommonModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf0980c3e78f0955fb27d457333db7afd6d734d", @"/Areas/Mobile/Templates/Default/Views/MyGifts/OrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"251375f151a8ed74fad18b07a59f5490bcea9ba2", @"/Areas/Mobile/Templates/Default/Views/_ViewImports.cshtml")]
    public class Areas_Mobile_Templates_Default_Views_MyGifts_OrderDetail : Mall.Web.Framework.MobileWebViewPage<Mall.Web.Areas.Mobile.Models.MyGiftsOrderDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
  
    ViewBag.Title = "礼品订单详情";
    ViewBag.ShowAside = 3;//显示浮动菜单栏、回到顶部按钮

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"gift-address\">\r\n    \t<div class=\"street-well\">\r\n\t        <h3>");
#nullable restore
#line 9 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
            Write(Model.OrderData.ShipTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("，");
#nullable restore
#line 9 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
                                      Write(Model.OrderData.CellPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t        <p>");
#nullable restore
#line 10 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
           Write(Model.OrderData.RegionFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
                                             Write(Model.OrderData.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t        <i class=\"icon\"></i>\r\n        </div>\r\n    </div>\r\n\r\n    <ul class=\"gift-order-list\">\r\n        <li>\r\n            <div class=\"gift-order-hd\">\r\n                <i class=\"glyphicon glyphicon-list-alt\"></i>");
#nullable restore
#line 18 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
                                                        Write(Model.OrderData.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"active\">");
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
                                 Write(Model.OrderData.ShowOrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
             foreach (var item in Model.OrderItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"gift-item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 850, "\"", 954, 1);
#nullable restore
#line 24 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
WriteAttributeValue("", 856, Mall.Core.MallIO.GetProductSizeImage(item.ImagePath, 1, (int)Mall.CommonModel.ImageSize.Size_150), 856, 98, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <p>");
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
                  Write(item.GiftName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <span>");
#nullable restore
#line 26 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
                     Write(item.SaleIntegral);

#line default
#line hidden
#nullable disable
            WriteLiteral("<em>积分</em><br />× ");
#nullable restore
#line 26 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
                                                          Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"gift-order-txt\">共 <span>");
#nullable restore
#line 29 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
                                            Write(Model.OrderItems.Sum(d => d.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> 件礼品  花费积分：<span>");
#nullable restore
#line 29 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
                                                                                                            Write(Model.OrderData.TotalIntegral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
             if (Model.OrderData.OrderStatus == Mall.Entities.GiftOrderInfo.GiftOrderStatus.WaitReceiving)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"gift-order-bot border-top\">\r\n                <a class=\"gift-btn light\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1504, "\"", 1551, 3);
            WriteAttributeValue("", 1514, "ConfirmOrder(\'", 1514, 14, true);
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
WriteAttributeValue("", 1528, Model.OrderData.Id, 1528, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1549, "\')", 1549, 2, true);
            EndWriteAttribute();
            WriteLiteral(">确认收货</a>\r\n            </div>\r\n");
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </li>\r\n    </ul>\r\n    <div class=\"gift-order-detail\">\r\n        <p>兑换时间：");
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
            Write(Model.OrderData.OrderDate.ToString("yyyy-MM-dd HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 40 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.OrderData.ShipOrderNumber))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"border-top\">运单号码：");
#nullable restore
#line 42 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
                                   Write(Model.OrderData.ShipOrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 43 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.OrderData.ExpressCompanyName))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"border-top\">物流公司：");
#nullable restore
#line 46 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
                                   Write(Model.OrderData.ExpressCompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 47 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\MyGifts\OrderDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>



<script>

    function ConfirmOrder(orderId) {
        $.dialog.confirm(""你确定收到货了吗？"", function () { Confirm(orderId); });
    }

    function Confirm(orderId) {
        var loading = showLoading();
        $.ajax({
            type: 'post',
            url: ""/"" + areaName + ""/MyGifts/ConfirmOrderOver"",
            dataType: 'json',
            data: { OrderId: orderId },
            success: function (d) {
                loading.close();
                if (d.success) {
                    $.dialog.succeedTips(""确认成功！"", function () {
                        window.location.reload();
                    }, 1);
                }
                else {
                    $.dialog.errorTips(""确认失败！"", '', 2);
                }
            }
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.Web.Areas.Mobile.Models.MyGiftsOrderDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
