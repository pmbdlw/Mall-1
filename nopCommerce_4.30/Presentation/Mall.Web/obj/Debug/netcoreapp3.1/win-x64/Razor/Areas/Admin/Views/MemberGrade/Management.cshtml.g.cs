#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f9e58ea1eddb41a7dc63c5dff81b3f3273197c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_MemberGrade_Management), @"mvc.1.0.view", @"/Areas/Admin/Views/MemberGrade/Management.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9e58ea1eddb41a7dc63c5dff81b3f3273197c9", @"/Areas/Admin/Views/MemberGrade/Management.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdcb39a21de2ae84fe919284139b99d5fdc20b3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_MemberGrade_Management : Mall.Web.Framework.WebViewPage<IEnumerable<Mall.Entities.MemberGradeInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/CommonJS.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Admin/Scripts/MemberGradeManagement.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
  
    ViewBag.Title = "分类管理";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9e58ea1eddb41a7dc63c5dff81b3f3273197c96783", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9e58ea1eddb41a7dc63c5dff81b3f3273197c97822", async() => {
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
            WriteLiteral(@"

<div class=""container"">
    <ul class=""nav nav-tabs-custom clearfix"">
        <li class=""active""><a>管理</a></li>
        <li><a href=""./Add"">新增</a></li>
    </ul>
	<div class=""queryDiv"">
		<img class=""queryImg"" src=""/Images/ic_query.png"">
		<div class=""tipBox"">
			<h5>温馨提示:</h5>
			<ul>
				<li><span>注意：折扣率仅适用于官方自营店以及店铺下的门店。</span></li>
			</ul>
		</div>
	</div>
    <table class=""table category_table mt20"">
        <thead>
            <tr>
                <th class=""tac"">会员等级</th>
                <th class=""tac"">需要积分</th>
                <th class=""tac"">可享折扣率</th>
                <th width=""500"" class=""tac"">备注</th>
                <th class=""td-operate tac"">操作</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tac\">\r\n                    <td class=\"tac clear-u6\" colspan=\"4\">没有添加任何会员等级</td>\r\n                </tr>\r\n");
#nullable restore
#line 38 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
            }
            else
            {
                foreach (var grade in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"tac\">\r\n                        <td>");
#nullable restore
#line 44 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
                       Write(grade.GradeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 46 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
                       Write(grade.Integral);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 49 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
                       Write(grade.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 51 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
                       Write(grade.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"td-operate\">\r\n                            <span class=\"btn-a\"><a");
            BeginWriteAttribute("href", " href=\"", 1703, "\"", 1724, 2);
            WriteAttributeValue("", 1710, "edit/", 1710, 5, true);
#nullable restore
#line 53 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
WriteAttributeValue("", 1715, grade.Id, 1715, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">编辑</a></span>\r\n                            <span class=\"btn-a\"><a");
            BeginWriteAttribute("class", " class=\"", 1791, "\"", 1843, 3);
            WriteAttributeValue("", 1799, "good-check", 1799, 10, true);
            WriteAttributeValue(" ", 1809, "candel", 1810, 7, true);
#nullable restore
#line 54 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
WriteAttributeValue("", 1816, grade.IsNoDelete?"0":"1", 1816, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1844, "\"", 1909, 5);
            WriteAttributeValue("", 1854, "DeleteGrade(this,", 1854, 17, true);
#nullable restore
#line 54 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
WriteAttributeValue("", 1871, grade.Id, 1871, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1880, ",", 1880, 1, true);
#nullable restore
#line 54 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
WriteAttributeValue("", 1881, grade.IsNoDelete?"0":"1", 1881, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1908, ")", 1908, 1, true);
            EndWriteAttribute();
            WriteLiteral(">删除</a></span>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\MemberGrade\Management.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mall.Entities.MemberGradeInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
