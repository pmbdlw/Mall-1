#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "414726e3440d0ca9171b93e7df85f13209a58444"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductType_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductType/Edit.cshtml")]
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
#line 3 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
using Mall.CommonModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
using Mall.Web.Areas.Admin.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"414726e3440d0ca9171b93e7df85f13209a58444", @"/Areas/Admin/Views/ProductType/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdcb39a21de2ae84fe919284139b99d5fdc20b3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductType_Edit : Mall.Web.Framework.WebViewPage<Mall.Entities.TypeInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Admin/Scripts/ProductType.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("./SaveModel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("typeForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414726e3440d0ca9171b93e7df85f13209a584448609", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"container clear-o\">\r\n    <ul class=\"breadcrumb clearfix\">\r\n\r\n        <li><a>类型列表</a></li>\r\n        <li><a>");
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
           Write(Model.Id==0?"添加": "编辑");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"类型</a></li>

    </ul>
    <div class=""queryDiv"">
		<img class=""queryImg"" src=""/Images/ic_query.png"">
		<div class=""tipBox"">
			<h5>温馨提示:</h5>
			<ul>
				<li><span>商品类型：商品类型是用来管理属性集合的，包括有品牌、属性、规格。当商品分类关联了某个类型后，这个分类下的商品就拥有了这些品牌、属性、规格。</span></li>
			</ul>
		</div>
	</div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414726e3440d0ca9171b93e7df85f13209a5844410325", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label");
                BeginWriteAttribute("for", " for=\"", 773, "\"", 779, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"col-sm-2 control-label\">类型名称：</label>\r\n            <div class=\"col-sm-7\">\r\n                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 897, "\"", 916, 1);
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
WriteAttributeValue("", 905, Model.Name, 905, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Name"" id=""typeName"" class=""form-control input-sm"" maxlength=""40"" />
                <span class=""field-validation-error"" id=""typeNameTip""></span>
                <span style=""display:none;"" id=""nameErrorMsg"" class=""help-default cor-red""><span>名称不能为空</span></span>
                <input type=""hidden"" name=""Id""");
                BeginWriteAttribute("value", " value=\"", 1237, "\"", 1254, 1);
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
WriteAttributeValue("", 1245, Model.Id, 1245, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"Id\"/>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label");
                BeginWriteAttribute("for", " for=\"", 1355, "\"", 1361, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""col-sm-2 control-label"">关联品牌：</label>
            <div class=""col-sm-9 brand-letter"" id=""id_tab"">
              
            </div>
            <div class=""col-sm-9 brand-group"">
                <div class=""checkbox-group"">
                </div>
                <div id=""id_s"" class=""choose-brand"">
                	<span>已选择：</span>
                </div>
            </div>
        </div>

        <div class=""form-group"">
            <label");
                BeginWriteAttribute("for", " for=\"", 1828, "\"", 1834, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""col-sm-2 control-label"">属性：</label>
            <div class=""col-sm-9"">
                <table class=""table table-bordered typeTable"">
                    <thead>
                        <tr>
                            <th width=""30%"">属性名</th>
                            <th width=""50%"">属性值</th>
                            <th width=""20%"" class=""td-operate"">操作</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 63 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
                         if (Model.AttributeInfo==null || Model.AttributeInfo.Count==0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <tr id=""nonDataContainer"">
                                <td width=""100%"" class=""text-center"" colspan=""3"">
                                    <h6>没有任何属性信息</h6>
                                </td>
                            </tr>
");
#nullable restore
#line 70 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
                        }
                        else
                        {
                            int index = 0;
                            foreach (var item in Model.AttributeInfo)
                            {
                                
                                var attrName = "Attributes[" + index.ToString() + "].Name";
                                var attrValue = "Attributes[" + index.ToString() + "].Value";
                                var attrId = "Attributes[" + index.ToString() + "].Id";
                                var attrIsMulti = "Attributes[" + index.ToString() + "].IsMulti";
                                index++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr class=\"currentRow\">\r\n                                    <td width=\"30%\">\r\n                                        <input class=\"attrId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3561, "\"", 3577, 1);
#nullable restore
#line 84 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
WriteAttributeValue("", 3569, item.Id, 3569, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3578, "\"", 3592, 1);
#nullable restore
#line 84 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
WriteAttributeValue("", 3585, attrId, 3585, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input class=\"attrIsMulti\"");
                BeginWriteAttribute("name", " name=\"", 3664, "\"", 3683, 1);
#nullable restore
#line 85 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
WriteAttributeValue("", 3671, attrIsMulti, 3671, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3698, "\"", 3730, 1);
#nullable restore
#line 85 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
WriteAttributeValue("", 3706, item.IsMulti.ToString(), 3706, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input class=\"attrName\"");
                BeginWriteAttribute("name", " name=\"", 3799, "\"", 3815, 1);
#nullable restore
#line 86 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
WriteAttributeValue("", 3806, attrName, 3806, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3830, "\"", 3848, 1);
#nullable restore
#line 86 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
WriteAttributeValue("", 3838, item.Name, 3838, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <span class=\"spanAttrName\">");
#nullable restore
#line 87 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    </td>\r\n                                    <td width=\"50%\">\r\n                                        <input class=\"attrValue\"");
                BeginWriteAttribute("name", " name=\"", 4101, "\"", 4118, 1);
#nullable restore
#line 90 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
WriteAttributeValue("", 4108, attrValue, 4108, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4133, "\"", 4156, 1);
#nullable restore
#line 90 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
WriteAttributeValue("", 4141, item.AttrValue, 4141, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <span class=\"spanAttrValue clearo1 overflow-ellipsis\"");
                BeginWriteAttribute("title", " title=\"", 4255, "\"", 4278, 1);
#nullable restore
#line 91 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
WriteAttributeValue("", 4263, item.AttrValue, 4263, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 91 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
                                                                                                                 Write(item.AttrValue);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    </td>\r\n                                    <td width=\"20%\" class=\"td-operate\"><span class=\"btn-a\"><a class=\"attrEdit\">编辑</a><a class=\"attrDelete\">删除</a></span></td>\r\n                                </tr>\r\n");
#nullable restore
#line 95 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"

                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </tbody>
                </table>
                <a class=""add-atrr""><span class=""glyphicon glyphicon-plus-sign""></span>新增一个属性</a>
                <span class=""help-default ml15"">您可添加多个商品属性，商品属性作为前端筛选条件同时也会在商品详情页上显示</span>
            </div>
        </div>
        <div class=""form-group"">
            <label");
                BeginWriteAttribute("for", " for=\"", 4943, "\"", 4949, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"col-sm-2 control-label\">规格：</label>\r\n            <div class=\"col-sm-9 type\">\r\n                <div class=\"type-list\" id=\"divColor\">\r\n                    ");
#nullable restore
#line 109 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
               Write(Html.GenerateSpecification(Model, SpecificationType.Color));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"type-list\" id=\"divSize\">\r\n                    ");
#nullable restore
#line 112 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
               Write(Html.GenerateSpecification(Model, SpecificationType.Size));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"type-list\" id=\"divVersion\">\r\n                    ");
#nullable restore
#line 115 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\ProductType\Edit.cshtml"
               Write(Html.GenerateSpecification(Model, SpecificationType.Version));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <p class=""help-block"">勾选的规格才会在商家发布商品，选择此类型对应的分类时显示出来；建议3个规格全选，否则商家导入多规格商品时，会显示不全；平台设置的默认值，商家在发布商品时是可以修改名称的（不会影响平台数据）</p>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-sm-offset-2 col-sm-10"">
                <input type=""button"" onclick=""subForm();"" class=""btn btn-primary"" value=""保 存"" />
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.Entities.TypeInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
