#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ddd1ee5f3f2e634ca63ea3758b85d712cfa5bd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Statistics_ExportTradeStatistic), @"mvc.1.0.view", @"/Areas/Admin/Views/Statistics/ExportTradeStatistic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ddd1ee5f3f2e634ca63ea3758b85d712cfa5bd4", @"/Areas/Admin/Views/Statistics/ExportTradeStatistic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdcb39a21de2ae84fe919284139b99d5fdc20b3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Statistics_ExportTradeStatistic : Mall.Web.Framework.WebViewPage<List<Mall.DTO.TradeStatisticModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
  
    object Title = new object();
    ViewData.TryGetValue("Title", out Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<table cellspacing=\"0\" cellpadding=\"5\" rules=\"all\" border=\"1\">\r\n    <thead>\r\n        <tr>\r\n            <th colspan=\"3\">");
#nullable restore
#line 9 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
                        Write(ViewData["Title"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
        </tr>
        <tr>
            <th>时间</th>
            <th>浏览人数</th>
            <th>下单人数</th>
            <th>订单数</th>
            <th>下单金额</th>
            <th>付款人数</th>
            <th>付款订单</th>
            <th>付款件数</th>
            <th>付款金额</th>
            <th>客单价</th>
            <th>下单转化率</th>
            <th>付款转化率</th>
            <th>交易转化率</th>
        </tr>
    </thead>
    <tbody id=""list-table-body"">
");
#nullable restore
#line 28 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.VisitCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.OrderUserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.OrderCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.OrderAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.OrderPayUserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.OrderPayCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.SaleCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.SaleAmounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 40 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
                 if (item.SaleCounts > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 42 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
                    Write(Math.Round(Convert.ToDecimal(item.SaleAmounts / item.OrderPayCount), 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 43 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>0</td>\r\n");
#nullable restore
#line 47 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 48 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.OrderConversionsRatesString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.PayConversionsRatesString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
               Write(item.TransactionConversionRateString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\ExportTradeStatistic.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mall.DTO.TradeStatisticModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
