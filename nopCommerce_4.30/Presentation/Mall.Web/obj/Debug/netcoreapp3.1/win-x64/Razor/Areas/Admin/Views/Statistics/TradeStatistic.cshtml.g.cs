#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5edd9045042eff1ace516a428afaf69c2514ed3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Statistics_TradeStatistic), @"mvc.1.0.view", @"/Areas/Admin/Views/Statistics/TradeStatistic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5edd9045042eff1ace516a428afaf69c2514ed3e", @"/Areas/Admin/Views/Statistics/TradeStatistic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdcb39a21de2ae84fe919284139b99d5fdc20b3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Statistics_TradeStatistic : Mall.Web.Framework.WebViewPage<Mall.DTO.TradeStatisticModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Admin/Scripts/PlatTradeStatistic.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/echarts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/CommonJS.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
  
    ViewBag.Title = "交易统计";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""/Content/bootstrap.min.css?v=2.4"" rel=""stylesheet"">
<link rel=""stylesheet"" type=""text/css"" media=""all"" href=""/Content/daterangepicker-bs3.css"" />

<script type=""text/javascript"" src=""/Scripts/bootstrap.min.js""></script>
<script type=""text/javascript"" src=""/Scripts/moment.js""></script>
<script type=""text/javascript"" src=""/Scripts/daterangepicker.js""></script>
<script type=""text/javascript"" src=""/Scripts/bootstrap-datetimepicker.min.js""></script>
<script type=""text/javascript"" src=""/Scripts/bootstrap-datetimepicker.zh-CN.js""></script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5edd9045042eff1ace516a428afaf69c2514ed3e7767", async() => {
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
            WriteLiteral(@"
<style type=""text/css"">
	.queryDiv{
	    right: 110px;
    	top: 85px;
	}
</style>
<div class=""container"">
    <ul class=""nav nav-tabs-custom clearfix"">
        <li class=""active""><a>交易数据</a></li>
    </ul>
    <div class=""queryDiv"">
		<img class=""queryImg"" src=""/Images/ic_query.png"">
		<div class=""tipBox"">
			<h5>温馨提示:</h5>
			<ul>
				<li><span>统计了时间段内平台的整体销售情况，包括整体下单人数，下单金额，转化率等等。</span></li>
			</ul>
		</div>
	</div>
    <a class=""export-data"" id=""aMonthExport"" href=""javascript:void(0);"" onclick=""ExportExecl()"">导出数据</a>
    <div class=""form-inline custom-inline sdata-trade"">
        <div class=""form-group pdata"">
            <a class=""active"" id=""defaultBtn""");
            BeginWriteAttribute("onclick", " onclick=\"", 1395, "\"", 1531, 5);
            WriteAttributeValue("", 1405, "LoadChartData(\'", 1405, 15, true);
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
WriteAttributeValue("", 1420, DateTime.Now.Date.AddDays(-1).ToString("yyyy-MM-dd"), 1420, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1473, "\',\'", 1473, 3, true);
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
WriteAttributeValue("", 1476, DateTime.Now.Date.AddDays(-1).ToString("yyyy-MM-dd"), 1476, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1529, "\')", 1529, 2, true);
            EndWriteAttribute();
            WriteLiteral(">昨天</a>\r\n            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1555, "\"", 1691, 5);
            WriteAttributeValue("", 1565, "LoadChartData(\'", 1565, 15, true);
#nullable restore
#line 38 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
WriteAttributeValue("", 1580, DateTime.Now.Date.AddDays(-7).ToString("yyyy-MM-dd"), 1580, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1633, "\',\'", 1633, 3, true);
#nullable restore
#line 38 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
WriteAttributeValue("", 1636, DateTime.Now.Date.AddDays(-1).ToString("yyyy-MM-dd"), 1636, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1689, "\')", 1689, 2, true);
            EndWriteAttribute();
            WriteLiteral(">最近7天</a>\r\n            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1717, "\"", 1854, 5);
            WriteAttributeValue("", 1727, "LoadChartData(\'", 1727, 15, true);
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
WriteAttributeValue("", 1742, DateTime.Now.Date.AddDays(-30).ToString("yyyy-MM-dd"), 1742, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1796, "\',\'", 1796, 3, true);
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
WriteAttributeValue("", 1799, DateTime.Now.Date.AddDays(-1).ToString("yyyy-MM-dd"), 1799, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1852, "\')", 1852, 2, true);
            EndWriteAttribute();
            WriteLiteral(">最近30天</a>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <input id=\"inputStartDate\" class=\"form-control input-ssm w220 start_datetime has-dateicon\"");
            BeginWriteAttribute("value", " value=\"", 2019, "\"", 2027, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""区间日期"" type=""text"">
            <i class=""glyphicon glyphicon-calendar""></i>
        </div>
    </div>

    <div class=""chart_1"">
        <div id=""content"">
            <div class=""chart_1_1"">
                <div class=""chart_list chart_list_visit"">
                    <div class=""chart_list_cell"">
                        <span><i class=""gd01""></i>浏览量</span>
                        <b id=""vistiCounts"">");
#nullable restore
#line 53 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                       Write(Model.VisitCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                    </div>
                </div>
                <div class=""chart_list chart_list_order"">
                    <div class=""chart_list_cell"">
                        <span><i class=""gd02""></i>下单人数</span>
                        <b id=""orderUserCount"">");
#nullable restore
#line 59 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                          Write(Model.OrderUserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div class=\"chart_list_cell\">\r\n                        <span>订单数</span>\r\n                        <b id=\"orderCount\">");
#nullable restore
#line 63 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                      Write(Model.OrderCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div class=\"chart_list_cell\">\r\n                        <span>下单件数</span>\r\n                        <b id=\"orderProductCount\">");
#nullable restore
#line 67 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                             Write(Model.OrderProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div class=\"chart_list_cell\">\r\n                        <span>下单金额</span>\r\n                        <b id=\"orderAmount\">");
#nullable restore
#line 71 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                       Write(Model.OrderAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
                    </div>
                </div>
                <div class=""chart_list chart_list_pay"">
                    <div class=""chart_list_cell"">
                        <span><i class=""gd03""></i>付款人数</span>
                        <b id=""orderPayUserCount"">");
#nullable restore
#line 77 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                             Write(Model.OrderPayUserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div class=\"chart_list_cell\">\r\n                        <span>付款订单数</span>\r\n                        <b id=\"orderPayCount\">");
#nullable restore
#line 81 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                         Write(Model.OrderPayCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div class=\"chart_list_cell\">\r\n                        <span>付款件数</span>\r\n                        <b id=\"saleCounts\">");
#nullable restore
#line 85 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                      Write(Model.SaleCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div class=\"chart_list_cell\">\r\n                        <span>付款金额</span>\r\n                        <b id=\"saleAmounts\">");
#nullable restore
#line 89 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                       Write(Model.SaleAmounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div class=\"chart_list_cell\">\r\n                        <span>客单价</span>\r\n                        <b id=\"customPrice\">");
#nullable restore
#line 93 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                        Write(Model.OrderPayUserCount > 0 ? (Math.Round(Convert.ToDecimal( Model.SaleAmounts / Model.OrderPayUserCount),2)) : 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                </div>\r\n                <div class=\"region region_1\">\r\n                    <p>下单转化率</p>\r\n                    <b id=\"orderConversionsRates\">");
#nullable restore
#line 98 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                              Write(Model.OrderConversionsRates);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</b>\r\n                </div>\r\n                <div class=\"region region_2\">\r\n                    <p>付款转化率</p>\r\n                    <b id=\"payConversionsRates\">");
#nullable restore
#line 102 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                            Write(Model.PayConversionsRates);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</b>\r\n                </div>\r\n                <div class=\"region region_3\">\r\n                    <p>成交转化率</p>\r\n                    <b id=\"transactionConversionRate\">");
#nullable restore
#line 106 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Statistics\TradeStatistic.cshtml"
                                                  Write(Model.TransactionConversionRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</b>
                </div>
                <img src=""/images/trade-an_03.png"" class=""chart_funnel"">
            </div>
        </div>
        <div class=""count-chat"">
            <div id=""mainChartFunnel"" style=""height:500px;border:1px solid #ccc;padding:10px;display:none;""></div>
            <div id=""mainChartLine"" style=""height:500px;padding:10px;margin-top:215px;""></div>

        </div>
       
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5edd9045042eff1ace516a428afaf69c2514ed3e19786", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5edd9045042eff1ace516a428afaf69c2514ed3e20826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    $(function () {\r\n        $(\".sdata-trade .pdata a\").click(function () {\r\n            $(this).addClass(\"active\").siblings().removeClass(\"active\")\r\n        })\r\n    })\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.DTO.TradeStatisticModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
