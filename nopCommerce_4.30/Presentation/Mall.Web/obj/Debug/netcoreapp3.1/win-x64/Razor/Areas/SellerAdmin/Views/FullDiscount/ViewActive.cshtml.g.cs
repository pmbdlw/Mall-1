#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f78d746cf45681f3a03c6d5a7bf41a0f48584485"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SellerAdmin_Views_FullDiscount_ViewActive), @"mvc.1.0.view", @"/Areas/SellerAdmin/Views/FullDiscount/ViewActive.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f78d746cf45681f3a03c6d5a7bf41a0f48584485", @"/Areas/SellerAdmin/Views/FullDiscount/ViewActive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5955669422911a11135b862f296047894c21785d", @"/Areas/SellerAdmin/Views/_ViewImports.cshtml")]
    public class Areas_SellerAdmin_Views_FullDiscount_ViewActive : Mall.Web.Framework.WebViewPage<Mall.DTO.FightGroupActiveModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
  
    ViewBag.Title = "活动详情";
    var curnum = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container clear-v20\">\r\n    <ul class=\"nav nav-tabs-custom clearfix\">\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 189, "\"", 197, 0);
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 201, "\"", 228, 1);
#nullable restore
#line 8 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
WriteAttributeValue("", 208, Url.Action("Index"), 208, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">所有拼团</a></li>\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 256, "\"", 264, 0);
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 268, "\"", 299, 1);
#nullable restore
#line 9 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
WriteAttributeValue("", 275, Url.Action("AddActive"), 275, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">添加拼团</a></li>\r\n        <li class=\"active\"><a>拼团详情</a></li>\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 372, "\"", 380, 0);
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 384, "\"", 422, 1);
#nullable restore
#line 11 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
WriteAttributeValue("", 391, Url.Action("BuyMarketService"), 391, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">购买服务</a></li>\r\n    </ul>\r\n\r\n    <div class=\"form-horizontal\">\r\n        <div class=\"form-group\">\r\n            <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 570, "\"", 576, 0);
            EndWriteAttribute();
            WriteLiteral(">活动商品：</label>\r\n            <div class=\"col-sm-7\"><label class=\" control-label\"");
            BeginWriteAttribute("for", " for=\"", 656, "\"", 662, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                                                   Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 801, "\"", 807, 0);
            EndWriteAttribute();
            WriteLiteral(@">商品详情：</label>
            <div class=""col-sm-9"">
                <table id=""tbl"" class=""table table-bordered"">
                    <thead>
                        <tr>
                            <td width=""32%"">主商品</td>
                            <td width=""32%"">规格</td>
                            <td width=""12%"">原价</td>
                            <td width=""12%"">限时价</td>
                            <td width=""12%"">库存</td>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                         foreach (var item in Model.ActiveItems)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n");
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                             if (curnum == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td width=\"32%\"");
            BeginWriteAttribute("rowspan", " rowspan=\"", 1587, "\"", 1623, 1);
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
WriteAttributeValue("", 1597, Model.ActiveItems.Count, 1597, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 1649, "\"", 1681, 1);
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
WriteAttributeValue("", 1655, Model.ProductDefaultImage, 1655, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n");
#nullable restore
#line 40 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td width=\"32%\">");
#nullable restore
#line 41 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                            Write(item.SkuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td width=\"12%\">");
#nullable restore
#line 42 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                            Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td width=\"12%\">");
#nullable restore
#line 43 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                            Write(item.ActivePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td width=\"12%\">");
#nullable restore
#line 44 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                            Write(item.ActiveStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 46 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"

                                { 
                                    curnum = curnum + 1;
                                }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 2416, "\"", 2422, 0);
            EndWriteAttribute();
            WriteLiteral(">活动列表图片：</label>\r\n                <div class=\"col-sm-3\"><a");
            BeginWriteAttribute("href", " href=\"", 2481, "\"", 2504, 1);
#nullable restore
#line 59 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
WriteAttributeValue("", 2488, Model.IconUrl, 2488, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><img");
            BeginWriteAttribute("src", " src=\"", 2526, "\"", 2548, 1);
#nullable restore
#line 59 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
WriteAttributeValue("", 2532, Model.IconUrl, 2532, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" /></a></div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 2689, "\"", 2695, 0);
            EndWriteAttribute();
            WriteLiteral(">开始时间：</label>\r\n                <div class=\"col-sm-3\"><label class=\" control-label\"");
            BeginWriteAttribute("for", " for=\"", 2779, "\"", 2785, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                                                       Write(Model.StartTime.ToString("yyyy-MM-dd HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 2968, "\"", 2974, 0);
            EndWriteAttribute();
            WriteLiteral(">结束时间：</label>\r\n                <div class=\"col-sm-3\"><label class=\"control-label\"");
            BeginWriteAttribute("for", " for=\"", 3057, "\"", 3063, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 70 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                                                      Write(Model.EndTime.ToString("yyyy-MM-dd HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 3242, "\"", 3248, 0);
            EndWriteAttribute();
            WriteLiteral(">成团人数：</label>\r\n                <div class=\"col-sm-3\"><label class=\"control-label\"");
            BeginWriteAttribute("for", " for=\"", 3331, "\"", 3337, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 75 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                                                      Write(Model.LimitedNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("人</label></div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 3491, "\"", 3497, 0);
            EndWriteAttribute();
            WriteLiteral(">成团时限：</label>\r\n                <div class=\"col-sm-3\"><label class=\"control-label\"");
            BeginWriteAttribute("for", " for=\"", 3580, "\"", 3586, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 80 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                                                      Write(Model.LimitedHour);

#line default
#line hidden
#nullable disable
            WriteLiteral("小时</label></div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 3739, "\"", 3745, 0);
            EndWriteAttribute();
            WriteLiteral(">购买限制：</label>\r\n                <div class=\"col-sm-3\"><label class=\"control-label\"");
            BeginWriteAttribute("for", " for=\"", 3828, "\"", 3834, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 85 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                                                      Write(Model.LimitQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 88 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
         if (Model.FightGroupManageAuditStatus == Mall.CommonModel.FightGroupManageAuditStatus.SoldOut)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 4105, "\"", 4111, 0);
            EndWriteAttribute();
            WriteLiteral(">下架原因：</label>\r\n                <div class=\"col-sm-3\"><label class=\"control-label\"");
            BeginWriteAttribute("for", " for=\"", 4194, "\"", 4200, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 93 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                                                      Write(Model.ManageRemark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 4350, "\"", 4356, 0);
            EndWriteAttribute();
            WriteLiteral(">下架时间：</label>\r\n                <div class=\"col-sm-3\"><label class=\"control-label\"");
            BeginWriteAttribute("for", " for=\"", 4439, "\"", 4445, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 97 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
                                                                      Write(Model.ManageDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n            </div>\r\n");
#nullable restore
#line 99 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\SellerAdmin\Views\FullDiscount\ViewActive.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.DTO.FightGroupActiveModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
