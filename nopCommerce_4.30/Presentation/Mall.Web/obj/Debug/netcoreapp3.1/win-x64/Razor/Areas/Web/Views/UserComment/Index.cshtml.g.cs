#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3928f0f4e4802240831aa8245fc8c120a509bd8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Web_Views_UserComment_Index), @"mvc.1.0.view", @"/Areas/Web/Views/UserComment/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3928f0f4e4802240831aa8245fc8c120a509bd8e", @"/Areas/Web/Views/UserComment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090c48694750ba7c62e752bf94ad67a159f3356f", @"/Areas/Web/Views/_ViewImports.cshtml")]
    public class Areas_Web_Views_UserComment_Index : Mall.Web.Framework.WebViewPage<IEnumerable<Mall.DTO.UserOrderCommentModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Web/Scripts/userComment.js?v=20183030"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
  
    Layout = "~/Areas/Web/Views/Shared/_UserCenter.cshtml";
    ViewBag.Title = "评价管理";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .tb-line>tbody>tr>td>a{color:#6b6c6e;font-size:13px;}
    .tb-line td{ padding: 7px 0;}
</style>
<div class=""box1 lh24"">
    <div class=""title bot-border"">
        <h3 class=""title_txt cur"">满意度评价</h3>
    </div>
    
    <div class=""border-box"" style=""margin-top:20px;"">
        <table class=""tb-void tb-line"" width=""100%"" cellspacing=""0"" cellpadding=""0"" border=""0"">
            <colgroup>
                <col width=""260"">
                <col width=""130"">
                <col width=""134"">
                <col width=""240"">
            </colgroup>
            <thead>
                <tr>
                    <th>订单编号</th>
                    <th>状态</th>
                    <th>评价时间</th>
                    <th>评价</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
                 if (Model.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr><td colspan=\"4\" class=\"ety\"><div class=\"empty\">暂时没有评论记录</div></td></tr>\r\n");
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
                  var i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
                 foreach (var m in Model)
                {
                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1357, "\"", 1423, 1);
#nullable restore
#line 43 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
WriteAttributeValue("", 1364, Url.Action("Detail", "UserOrder", new { id = @m.OrderId }), 1364, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:#6b6c6e;\">");
#nullable restore
#line 43 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
                                                                                                                    Write(m.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                        </td>
                        <td>
                           <strong state=""ddfk"" class=""ftx-02 order-statu"">已评价</strong>
                        </td>
                        <td>               
                            <span class=""ftx03"" style=""color:#6b6c6e;"">");
#nullable restore
#line 49 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
                                                                  Write(m.CommentTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>  \r\n                        <td>\r\n\r\n");
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1972, "\"", 2050, 1);
#nullable restore
#line 55 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
WriteAttributeValue("", 1979, Url.Action("Details", "OrderEvaluation", new { orderId = @m.OrderId }), 1979, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pj\" title=\"已评价\" catethird=\"0\" style=\"color:#e5a50c;font-size:14px;\">查看评价</a><br>\r\n");
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 67 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"mt10 clearfix\">\r\n            <div class=\"m clearfix\" id=\"bottom_pager\">\r\n                <div id=\"pagin-btm\" class=\"pagin fr\" style=\"clear:both\">\r\n");
#nullable restore
#line 74 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
                      
                        var count = ((PagingInfo)ViewBag.pageInfo).TotalPages;
                        var curr = ((PagingInfo)ViewBag.pageInfo).CurrentPage;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
                     if (count > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
                   Write(Html.PageLinks((PagingInfo)ViewBag.pageInfo, x => Url.Action("Index", new { pageNo = x })));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"page-skip\">\r\n                            <em>&nbsp;&nbsp;共 ");
#nullable restore
#line 82 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
                                         Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 页&nbsp;&nbsp;&nbsp;&nbsp;</em>\r\n                        </span>\r\n");
#nullable restore
#line 84 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserComment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <!--pagin end-->\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3928f0f4e4802240831aa8245fc8c120a509bd8e13336", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mall.DTO.UserOrderCommentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
