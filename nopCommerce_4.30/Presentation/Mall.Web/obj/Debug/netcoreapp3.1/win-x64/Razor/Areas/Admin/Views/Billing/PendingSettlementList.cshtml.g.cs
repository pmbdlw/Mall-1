#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\PendingSettlementList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dce79435709f0c25f464576c44057396cd754782"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Billing_PendingSettlementList), @"mvc.1.0.view", @"/Areas/Admin/Views/Billing/PendingSettlementList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dce79435709f0c25f464576c44057396cd754782", @"/Areas/Admin/Views/Billing/PendingSettlementList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdcb39a21de2ae84fe919284139b99d5fdc20b3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Billing_PendingSettlementList : Mall.Web.Framework.WebViewPage<Mall.DTO.SettlementCycle>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.MallDatagrid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/bootstrap-datetimepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/bootstrap-datetimepicker.zh-CN.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline custom-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("HeadScript", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dce79435709f0c25f464576c44057396cd7547828072", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dce79435709f0c25f464576c44057396cd7547829167", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dce79435709f0c25f464576c44057396cd75478210349", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"container\">\r\n    <ul class=\"nav nav-tabs-custom clearfix\">\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 384, "\"", 411, 1);
#nullable restore
#line 11 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\PendingSettlementList.cshtml"
WriteAttributeValue("", 391, Url.Action("index"), 391, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">财务总览</a></li>\r\n\t\t<li class=\"active\"><a href=\"#\" onclick=\"return false\">待结算列表</a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 514, "\"", 550, 1);
#nullable restore
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\PendingSettlementList.cshtml"
WriteAttributeValue("", 521, Url.Action("SettlementList"), 521, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">已结算列表</a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 582, "\"", 619, 1);
#nullable restore
#line 14 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\PendingSettlementList.cshtml"
WriteAttributeValue("", 589, Url.Action("PlatAccountItem"), 589, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">结余明细</a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=\"", 650, "\"", 699, 1);
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\PendingSettlementList.cshtml"
WriteAttributeValue("", 657, Url.Action("SetSettlementWeek","account"), 657, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">结算周期设置</a></li>
    </ul>
    <div class=""queryDiv"">
		<img class=""queryImg"" src=""/Images/ic_query.png"">
		<div class=""tipBox"">
			<h5>温馨提示:</h5>
			<ul>
				<li><span>每个结算周期内平台与商家对所有“已完成”且过了售后维权期的订单进行核算，统计出与各个商家需要结算的金额。</span></li>
				<li><span>计算公式：平台应结金额 = 订单实付金额 + 积分抵扣金额 - 平台抽佣 - 分销佣金 - 退款金额。</span></li>
			</ul>
		</div>
	</div>
    <div class=""search-box"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dce79435709f0c25f464576c44057396cd75478213867", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label class=\"label-inline w75\"");
                BeginWriteAttribute("for", " for=\"", 1215, "\"", 1221, 0);
                EndWriteAttribute();
                WriteLiteral(@">商家名称</label>
                <input class=""form-control input-ssm"" type=""text"" id=""txtShopName"">
            </div>
            <div class=""form-group"">
                <button type=""button"" class=""btn btn-primary btn-sm"" id=""searchButton"">搜 索</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <table class=\"table\" id=\"list\"></table>\r\n\t<div class=\"tabel-operate\" id=\"operationButtons\">\r\n\t\t<a class=\"btn-export\"");
            BeginWriteAttribute("href", " href=\'", 1650, "\'", 1699, 1);
#nullable restore
#line 40 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\PendingSettlementList.cshtml"
WriteAttributeValue("", 1657, Url.Action("ExportPendingSettlementList"), 1657, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ExportExecl.call(this);\">导出EXCEL</a>\r\n\t</div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t<script>\r\n\t\tvar settlementOrdersUrl = \'");
#nullable restore
#line 47 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\PendingSettlementList.cshtml"
                              Write(Url.Action("PendingSettlementOrders"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

		$('.start_datetime').on('changeDate', function () {
			if ($("".end_datetime"").val()) {
				if ($("".start_datetime"").val() > $("".end_datetime"").val()) {
					$('.end_datetime').val($("".start_datetime"").val());
				}
			}

			$('.end_datetime').datetimepicker('setStartDate', $("".start_datetime"").val());
		});

		$(""#list"").MallDatagrid({
			url: 'PendingSettlementList',
			nowrap: false,
			rownumbers: true,
			NoDataMsg: '没有找到符合条件的待结算记录',
			border: false,
			fit: true,
			fitColumns: true,
			pagination: true,
			pageSize: 15,
			pagePosition: 'bottom',
			operationButtons: ""#operationButtons"",
			pageNumber: 1,
			columns: [[
                { field: ""shopName"", title: '商家名称', width: 'auto' },
                { field: ""amount"", title: ""本期预计结算"", width: 'auto', align: ""center"", sort: true },
                {
                    field: ""settmentTime"", title: ""预计结算时间"", width: 'auto', align: ""center"",
					formatter: function () { return '");
#nullable restore
#line 77 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\PendingSettlementList.cshtml"
                                                Write(Model.EndTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';}\r\n\t\t\t\t},\r\n\t\t\t\t{\r\n\t\t\t\t\tfield: \"cycle\", title: \"结算周期\", width: \'auto\', align: \"center\",\r\n\t\t\t\t\tformatter: function () { return \'");
#nullable restore
#line 81 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\PendingSettlementList.cshtml"
                                                Write(Model.BillingCycleStr);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';}
				},
				{
					field: ""last"", title: ""操作"", width: 'auto', align: ""center"",
					formatter: function (v, row) {
						return '<a href=""{0}?shopId={1}"">查看</a>'.format(settlementOrdersUrl,row.shopId);
					}
				}]]
		});

		$('#searchButton').click(function (e) {
			searchClose(e);
			var shopName = $.trim($('#txtShopName').val());
			$(""#list"").MallDatagrid('reload', { shopName: shopName });
		})

		function ExportExecl() {
			var shopName = $.trim($('#txtShopName').val());
			var href = $(this).attr('href').split('?')[0] + '?shopName={0}'.format(shopName);
			$(this).attr('href', href);
		}
	</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.DTO.SettlementCycle> Html { get; private set; }
    }
}
#pragma warning restore 1591