#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d5bb2735f23c239c3cdba9ff08ba7e2966f4a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mobile_Templates_Default_Views_Member_Center), @"mvc.1.0.view", @"/Areas/Mobile/Templates/Default/Views/Member/Center.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d5bb2735f23c239c3cdba9ff08ba7e2966f4a4", @"/Areas/Mobile/Templates/Default/Views/Member/Center.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"251375f151a8ed74fad18b07a59f5490bcea9ba2", @"/Areas/Mobile/Templates/Default/Views/_ViewImports.cshtml")]
    public class Areas_Mobile_Templates_Default_Views_Member_Center : Mall.Web.Framework.MobileWebViewPage<Mall.Web.Areas.Mobile.Models.MemberCenterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
  
    ViewBag.Title = "个人中心";
    ViewBag.FootIndex = 4;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\" style=\"padding-bottom:50px;\">\r\n    <div class=\"user-info clearfix\">\r\n");
#nullable restore
#line 11 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
         if (string.IsNullOrWhiteSpace(Model.userMemberInfo.CellPhone))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"phone-tips\">\r\n                <span><s></s>您还未绑定手机&nbsp;&nbsp;<a");
            BeginWriteAttribute("href", " href=\"", 389, "\"", 430, 1);
#nullable restore
#line 14 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
WriteAttributeValue("", 396, Url.Action("BindPhone", "Member"), 396, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">去绑定</a><em></em></span>\r\n                <i id=\"closeTip\"></i>\r\n            </div>\r\n");
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"AccountSecure\"><div class=\"img\"><img onerror=\"$(this).remove();this.onerror=null;\"");
            BeginWriteAttribute("src", " src=\"", 626, "\"", 684, 1);
#nullable restore
#line 18 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
WriteAttributeValue("", 632, Mall.Core.MallIO.GetImagePath(Model.Member.Photo), 632, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 685, "\"", 691, 0);
            EndWriteAttribute();
            WriteLiteral(" /><div class=\"border\"></div></div></a>\r\n        <p><span>");
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
             Write(string.IsNullOrWhiteSpace(Model.Member.RealName) ? Model.Member.Nick : Model.Member.RealName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                                                                                                         Write(Model.GradeName != null ? Model.GradeName : string.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n        <div class=\"user-fav row\">\r\n            <span class=\"col-xs-5\"><a href=\"CollectionProduct\"><i>");
#nullable restore
#line 21 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                                             Write(Model.FavoriteProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i><br />收藏的商品</a></span>\r\n            <span class=\"col-xs-2 line\"><br>|</span>\r\n            <span class=\"col-xs-5\"><a href=\"CollectionShop\"><i>");
#nullable restore
#line 23 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                                          Write(Model.CollectionShop);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i><br />收藏的店铺</a></span>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"my_menu\">\r\n        <div class=\"total-order\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1361, "\"", 1464, 2);
            WriteAttributeValue("", 1368, "../Member/Orders?orderStatus=0&returnUrl=", 1368, 41, true);
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
WriteAttributeValue("", 1409, HttpUtility.UrlEncode(Context.Request.GetDisplayUrl()), 1409, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h5>全部订单</h5> <i class=\"glyphicon glyphicon-menu-right\"></i><em>查看全部订单</em></a>\r\n");
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
             if (Model.SignInIsEnable && Model.CanSignIn)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a id=\"signbtn\"");
            BeginWriteAttribute("class", " class=\"", 1652, "\"", 1707, 2);
            WriteAttributeValue("", 1660, "SignIn-btn", 1660, 10, true);
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
WriteAttributeValue(" ", 1670, Model.CanSignIn ? "" : "disabled", 1671, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n");
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <ul class=\"clearfix\">\r\n            <li><a href=\"../Member/Orders?orderStatus=1\"><span class=\"icon01\"></span><p>待付款</p>");
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                                                                           Write(new HtmlString(Model.WaitingForPay == 0 ? "" : "<i>" + Model.WaitingForPay + "</i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n            <li><a href=\"../Member/Orders?orderStatus=2\"><span class=\"icon02\"></span><p>待发货</p>");
#nullable restore
#line 38 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                                                                           Write(new HtmlString(Model.WaitingForDelivery == 0 ? "" : "<i>" + Model.WaitingForDelivery + "</i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n            <li><a href=\"../Member/Orders?orderStatus=3\"><span class=\"icon03\"></span><p>待收货/消费</p>");
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                                                                              Write(new HtmlString(Model.WaitingForRecieve == 0 ? "" : "<i>" + Model.WaitingForRecieve + "</i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n            <li><a href=\"../Member/Orders?orderStatus=5\"><span class=\"icon04\"></span><p>待评论</p>");
#nullable restore
#line 40 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                                                                           Write(new HtmlString(Model.WaitingForComments == 0 ? "" : "<i>" + Model.WaitingForComments + "</i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n            <li><a href=\"../OrderRefund/RefundList\"><span class=\"icon05\"></span><p>退款/售后</p>");
#nullable restore
#line 41 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                                                                        Write(new HtmlString(Model.RefundOrders == 0 ? "" : "<i>" + Model.RefundOrders + "</i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
        </ul>
    </div>
    <div class=""groupp-top"">
        <div class=""list-grouppp"">
            <a href=""../Coupon/Management"">
                <b class=""icon06""></b><div class=""list"">我的优惠券</div>
                <span class=""glyphicon glyphicon-menu-right""></span>
");
#nullable restore
#line 49 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                 if (Model.CouponsCount > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"rt\">你有");
#nullable restore
#line 51 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                   Write(Model.CouponsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("张优惠券未使用</span>\r\n");
#nullable restore
#line 52 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"rt\"></span>\r\n");
#nullable restore
#line 56 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </a>
        </div>
        <div class=""list-grouppp"">
            <a href=""../Member/Integral"">
                <b class=""icon07""></b><div class=""list"">我的积分</div>
                <span class=""glyphicon glyphicon-menu-right""></span>
                <span class=""rt"">");
#nullable restore
#line 63 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                             Write(Model.MemberAvailableIntegrals);

#line default
#line hidden
#nullable disable
            WriteLiteral("分</span>\r\n            </a>\r\n        </div>\r\n        <div class=\"list-grouppp\" style=\"border:none;\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3743, "\"", 3856, 3);
            WriteAttributeValue("", 3750, "/common/site/pay?area=mobile&platform=", 3750, 38, true);
#nullable restore
#line 67 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
WriteAttributeValue("", 3788, ViewBag.AreaName.Replace("m-",""), 3788, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3824, "&controller=Capital&action=Index", 3824, 32, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <b class=\"icon08\"></b><div class=\"list\">我的资产</div>\r\n                <span class=\"glyphicon glyphicon-menu-right\"></span>\r\n");
#nullable restore
#line 70 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                 if (!Model.IsOpenRechargePresent)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"rt\">");
#nullable restore
#line 72 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                 Write(Model.Capital);

#line default
#line hidden
#nullable disable
            WriteLiteral("元</span>\r\n");
#nullable restore
#line 73 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"rt\"><em class=\'red\'>充值赠送</em></span>\r\n");
#nullable restore
#line 77 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </a>\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 82 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
     if (Model.IsShowDistributionMyShop || Model.IsShowDistributionOpenMyShop)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"groupp-middle\">\r\n");
#nullable restore
#line 85 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
             if (Model.IsShowDistributionOpenMyShop)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"list-grouppp\" style=\"border:none;\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4610, "\"", 4654, 1);
#nullable restore
#line 88 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
WriteAttributeValue("", 4617, Url.Action("MyShop", "Distribution"), 4617, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b class=\"icon9\"></b><div class=\"list\">");
#nullable restore
#line 89 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                                           Write(Model.DistributionOpenMyShopShow);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <span class=\"glyphicon glyphicon-menu-right\"></span>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 93 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
             if (Model.IsShowDistributionMyShop)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"list-grouppp\" style=\"border:none;\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 5059, "\"", 5103, 1);
#nullable restore
#line 97 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
WriteAttributeValue("", 5066, Url.Action("MyShop", "Distribution"), 5066, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <b class=\"icon10\"></b><div class=\"list\">");
#nullable restore
#line 98 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                                            Write(Model.DistributionMyShopShow);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <span class=\"glyphicon glyphicon-menu-right\"></span>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 102 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 104 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"groupp-middle2\">\r\n");
            WriteLiteral("        <div class=\"list-grouppp\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 5726, "\"", 5772, 1);
#nullable restore
#line 115 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
WriteAttributeValue("", 5733, Url.Action("MyGroups", "MyFightGroup"), 5733, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <b class=\"icon14\"></b><div class=\"list\">我的拼团</div>\r\n                <span class=\"glyphicon glyphicon-menu-right\"></span>\r\n");
#nullable restore
#line 118 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                 if (Model.BulidFightGroupNumber > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"rt \">");
#nullable restore
#line 120 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                                  Write(Model.BulidFightGroupNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("个团正在火拼中</span>\r\n");
#nullable restore
#line 121 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </a>\r\n        </div>\r\n    </div>\r\n    <div class=\"groupp-bottom\">\r\n\r\n        <div class=\"list-grouppp\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 6222, "\"", 6325, 2);
            WriteAttributeValue("", 6229, "../Order/ChooseShippingAddress?returnUrl=", 6229, 41, true);
#nullable restore
#line 128 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
WriteAttributeValue("", 6270, HttpUtility.UrlEncode(Context.Request.GetDisplayUrl()), 6270, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <b class=\"icon12\"></b><div class=\"list\">收货地址管理</div>\r\n                <span class=\"glyphicon glyphicon-menu-right\"></span>\r\n            </a>\r\n        </div>\r\n        <div class=\"list-grouppp\" style=\"border:none;\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 6574, "\"", 6621, 3);
            WriteAttributeValue("", 6581, "/", 6581, 1, true);
#nullable restore
#line 134 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
WriteAttributeValue("", 6582, CurrentAreaName, 6582, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6600, "/Member/AccountSecure", 6600, 21, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <b class=\"icon13\"></b><div class=\"list\">账号管理</div>\r\n                <span class=\"glyphicon glyphicon-menu-right\"></span>\r\n            </a>\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 141 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
      Html.RenderPartial("~/Areas/Mobile/Templates/Default/Views/Shared/_4ButtonsFoot.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 144 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
 if (Model.CanSignIn)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script type=""text/javascript"">
        $(function () {

            $(""#signbtn"").click(function () {
                var _t = $(this);
                if (!_t.hasClass(""disabled"")) {
                    var loading = showLoading();
                    $.post('../SignIn/Sign', null, function (result) {
                        loading.close();
                        if (result.success) {
                            _t.addClass(""disabled"")
                            $.dialog.succeedTips(result.msg, function () { window.location.reload(); });
                        }
                        else {
                            //$.dialog.errorTips('签到成功！<br>+5分<br>再签到2天奖50分');
                            $.dialog.errorTips(result.msg);
                        }
                    }, ""json"");
                }
            });
        });
    </script>
");
#nullable restore
#line 168 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Member\Center.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\r\n        $(function () {\r\n            $(\"#closeTip\").click(function () {\r\n                $(\".phone-tips\").hide();\r\n            })\r\n        })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.Web.Areas.Mobile.Models.MemberCenterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
