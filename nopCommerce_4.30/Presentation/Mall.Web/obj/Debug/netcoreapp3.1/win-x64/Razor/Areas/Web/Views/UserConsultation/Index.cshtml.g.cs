#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1fb60ab9157904d830ec4ea492eb0079af5b33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Web_Views_UserConsultation_Index), @"mvc.1.0.view", @"/Areas/Web/Views/UserConsultation/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1fb60ab9157904d830ec4ea492eb0079af5b33", @"/Areas/Web/Views/UserConsultation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090c48694750ba7c62e752bf94ad67a159f3356f", @"/Areas/Web/Views/_ViewImports.cshtml")]
    public class Areas_Web_Views_UserConsultation_Index : Mall.Web.Framework.WebViewPage<IEnumerable<Mall.Web.Models.ProductConsultationModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
  
    Layout = "~/Areas/Web/Views/Shared/_UserCenter.cshtml";
    ViewBag.Title = "商品咨询";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .tb-goods td{padding:25px 15px;}
    .tb-void a{color:#6b6c6e;font-size:13px;}
    .col3{padding:0;font-size:13px;color:#6b6c6e}

</style>
<div class=""box1 lh24"">
    <div class=""title"">
        <span class=""title_txt cur"">购买咨询</span>
    </div>
    <div class=""border-box"">
        <table class=""tb-void tb-goods"" style=""margin-top:20px;"">
            <colgroup>
                <col width=""60"">
                <col width=""250"">
                <col width=""400"">
            </colgroup>
            <thead>
                <tr>
                    <th style=""text-align: left;padding-left: 27px;"">咨询商品</th>
                    <th>商品名称</th>
                    <th>咨询回复</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                 if (Model.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr><td colspan=\"4\" class=\"ety\"><div class=\"empty\">暂时没有咨询记录！</div></td></tr>\r\n");
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                 foreach (var m in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td style=\"padding:25px 0;position:relative;left:15px;\">\r\n                            <div class=\"img-list\" style=\"text-align:left;\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1396, "\"", 1462, 1);
#nullable restore
#line 40 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
WriteAttributeValue("", 1403, Url.Action("Detail", "Product", new { id = @m.ProductId }), 1403, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                    <img width=\"80\" height=\"80\"");
            BeginWriteAttribute("src", " src=\"", 1545, "\"", 1647, 1);
#nullable restore
#line 41 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
WriteAttributeValue("", 1551, Mall.Core.MallIO.GetProductSizeImage(m.ProductPic, 1, (int)Mall.CommonModel.ImageSize.Size_100), 1551, 96, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1648, "\"", 1656, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                        </td>
                        <td style=""vertical-align:top;position:relative;top:3px;padding-left:22px;padding-right:50px;"">
                            <div class=""p-name"">
");
#nullable restore
#line 47 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                                  
                                    var name = m.ProductName.Length > 20 ? m.ProductName.Substring(0, 20) + "..." : m.ProductName;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2173, "\"", 2239, 1);
#nullable restore
#line 50 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
WriteAttributeValue("", 2180, Url.Action("Detail", "Product", new { id = @m.ProductId }), 2180, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 50 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                                                                                                                 Write(m.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </div>
                        </td>
                        <td >
                            <div class=""col3"" style=""position:relative;top:-4px;padding-right:9px;"">
                                <div class=""col3q"">
                                    <span");
            BeginWriteAttribute("title", " title=\"", 2571, "\"", 2601, 1);
#nullable restore
#line 56 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
WriteAttributeValue("", 2579, m.ConsultationContent, 2579, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fore2\">\r\n                                        我的咨询：");
#nullable restore
#line 57 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                                        Write(m.ConsultationContent.Replace("&nbsp", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                    <span class=\"ftx-03 time2\">");
#nullable restore
#line 59 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                                                          Write(m.ConsultationDate.ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"col3a mt5\">\r\n");
#nullable restore
#line 62 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                                     if (!string.IsNullOrWhiteSpace(m.ReplyContent))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"ftx04 col3a-lcol\">商家回复：</div>\r\n                                        <div class=\"col3a-rcol\">\r\n                                            ");
#nullable restore
#line 66 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                                       Write(m.ReplyContent.Replace("&nbsp", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                        <span class=\"ftx03 time\">");
#nullable restore
#line 68 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                                                             Write(m.ReplyDate.HasValue ? m.ReplyDate.Value.ToString("yyyy-MM-dd HH:mm") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 69 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 74 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"cl mt10\" id=\"bottom_pager\">\r\n            <div id=\"pagin-btm\" class=\"pagin fr\" style=\"clear:both\">\r\n");
#nullable restore
#line 79 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                  
                    var count = ((PagingInfo)ViewBag.pageInfo).TotalPages;
                    var curr = ((PagingInfo)ViewBag.pageInfo).CurrentPage;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                 if (count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
               Write(Html.PageLinks((PagingInfo)ViewBag.pageInfo, x => Url.Action("Index", new { pageNo = x })));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"page-skip\">\r\n                        <em>&nbsp;&nbsp;共 ");
#nullable restore
#line 87 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                                     Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 页&nbsp;&nbsp;&nbsp;&nbsp;</em>\r\n                    </span>\r\n");
#nullable restore
#line 89 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\UserConsultation\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mall.Web.Models.ProductConsultationModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
