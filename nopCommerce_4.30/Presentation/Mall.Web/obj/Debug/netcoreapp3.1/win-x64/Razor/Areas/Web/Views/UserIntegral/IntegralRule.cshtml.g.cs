#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccb7d960ef067e631901838b871316a07564c5ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Web_Views_UserIntegral_IntegralRule), @"mvc.1.0.view", @"/Areas/Web/Views/UserIntegral/IntegralRule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb7d960ef067e631901838b871316a07564c5ab", @"/Areas/Web/Views/UserIntegral/IntegralRule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090c48694750ba7c62e752bf94ad67a159f3356f", @"/Areas/Web/Views/_ViewImports.cshtml")]
    public class Areas_Web_Views_UserIntegral_IntegralRule : Mall.Web.Framework.WebViewPage<Mall.DTO.UserIntegralGroupModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
  
    Layout = "~/Areas/Web/Views/Shared/_UserCenter.cshtml";
    ViewBag.Title = "怎么获取积分";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""box1 lh24"">
    <div class=""border-box"">
        <table class=""tb-void tb-goods"">
            <thead>
                <tr class=""tr-td"">
                    <th width=""150"">项目</th>
                    <th>当前累积积分</th>
                    <th>规则说明</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                 if (Model.LoginIntegralRule > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tr-td\">\r\n                    <td>登录</td>\r\n                    <td class=\"red-lg\">");
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                                  Write(Model.LoginIntegral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>您每次登录都可获得一定积分奖励，每日只能获得一次登录积分</td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                 if (Model.CommentIntegralRule > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tr-td\">\r\n                    <td>评论</td>\r\n                    <td class=\"red-lg\">");
#nullable restore
#line 28 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                                  Write(Model.CommentIntegral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>您所购买的商品，发表评论可获得积分奖励</td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                 if (Model.ConsumptionIntegralRule > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tr-td\">\r\n                    <td>消费</td>\r\n                    <td class=\"red-lg\">");
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                                  Write(Model.ConsumptionIntegral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>您每次消费均可获得一定积分奖励</td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                 if (Model.BindWxIntegralRule > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tr-td\">\r\n                    <td>绑定</td>\r\n                    <td class=\"red-lg\">");
#nullable restore
#line 44 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                                  Write(Model.BindWxIntegral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>首次绑定平台下微信公众号可获得积分奖励</td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                 if (Model.RegIntegralRule > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tr-td\">\r\n                    <td>注册</td>\r\n                    <td class=\"red-lg\">");
#nullable restore
#line 52 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                                  Write(Model.RegIntegral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>注册并完成验证（手机或邮箱）可获得积分奖励</td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                 if (Model.InviteIntegralRule > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tr-td\">\r\n                    <td>邀请好友</td>\r\n                    <td class=\"red-lg\">");
#nullable restore
#line 60 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                                  Write(Model.InviteIntegral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>邀请好友注册并完成验证（手机或邮箱）可获得积分奖励</td>\r\n                </tr>\r\n");
#nullable restore
#line 63 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                 if (Model.SignInRule > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tr-td\">\r\n                    <td>签到</td>\r\n                    <td class=\"red-lg\">");
#nullable restore
#line 68 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                                  Write(Model.SignIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>每天登录签到可以获得积分奖励</td>\r\n                </tr>\r\n");
#nullable restore
#line 71 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserIntegral\IntegralRule.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.DTO.UserIntegralGroupModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
