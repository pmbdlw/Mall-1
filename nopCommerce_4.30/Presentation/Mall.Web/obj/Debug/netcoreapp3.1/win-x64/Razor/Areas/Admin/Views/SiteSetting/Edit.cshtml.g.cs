#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cf252eb7cb3e0aff05e862c500db2bfa83e3ccf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SiteSetting_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/SiteSetting/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cf252eb7cb3e0aff05e862c500db2bfa83e3ccf", @"/Areas/Admin/Views/SiteSetting/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdcb39a21de2ae84fe919284139b99d5fdc20b3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SiteSetting_Edit : Mall.Web.Framework.WebViewPage<Mall.Web.Models.SiteSettingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.MallUpload.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Admin/Scripts/SiteSettingEdit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/ueditor/ueditor.config.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/ueditor/ueditor.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cf252eb7cb3e0aff05e862c500db2bfa83e3ccf7319", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cf252eb7cb3e0aff05e862c500db2bfa83e3ccf8358", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cf252eb7cb3e0aff05e862c500db2bfa83e3ccf9397", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cf252eb7cb3e0aff05e862c500db2bfa83e3ccf10436", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link href=""/Content/jquery.onoff.css.css"" rel=""stylesheet"" />
<style type=""text/css"">
	#btnClearData{
		color: #2481d1;
	    margin-left: 90px;
    	margin-right: 30px;
    	cursor: pointer;
	}
	.help{
		color: #999;
	}
</style>

<div class=""container"">
    <ul class=""nav nav-tabs-custom clearfix"">
        <li class=""active""><a>站点设置</a></li>
    </ul>
    <div class=""queryDiv"">
        <img class=""queryImg"" src=""/Images/ic_query.png"">
        <div class=""tipBox"">
            <h5>温馨提示:</h5>
            <ul>
                <li><span>在此可以设置商城的基本信息，请按引导语进行设置。</span></li>
            </ul>
        </div>
    </div>
");
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
     using (Html.BeginForm("Edit", "SiteSetting", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal form-pt0\">\r\n\r\n            <h3 class=\"table-hd\">站点基本设置</h3>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 1199, "\"", 1205, 0);
            EndWriteAttribute();
            WriteLiteral(">网站名称：</label>\r\n                <div class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 42 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.EditorFor(item => item.SiteName, new { htmlAttributes = new { @class = "form-control input-sm" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""col-sm-4"">
                    <p class=""help-default"">显示在商城顶部欢迎信息等位置</p>
                </div>
            </div>

            <div class=""form-group upload-img"" id=""Logo""></div>

            <div class=""form-group upload-img"" id=""wxlogobox""></div>

            <div class=""form-group upload-img"" id=""MemberLogo""></div>

            <div class=""form-group upload-img"" id=""QRCode""></div>

            <div class=""form-group upload-img"" id=""PCLoginPic""></div>

            <div class=""form-group upload-img"" id=""PCBottomPic""></div>

            <div class=""form-group"">
                <label class=""col-sm-2 control-label""");
            BeginWriteAttribute("for", " for=\"", 2082, "\"", 2088, 0);
            EndWriteAttribute();
            WriteLiteral(">客服电话：</label>\r\n                <div class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 64 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.EditorFor(item => item.SitePhone, new { htmlAttributes = new { @class = "form-control input-sm" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""col-sm-4"">
                    <p class=""help-default"">提供小程序显示客服电话功能</p>
                </div>
            </div>

            <div class=""form-group"">
                <label class=""col-sm-2 control-label""");
            BeginWriteAttribute("for", " for=\"", 2537, "\"", 2543, 0);
            EndWriteAttribute();
            WriteLiteral(">是否提供APP下载：</label>\r\n                <div class=\"col-sm-8 form-control-static\">\r\n                    ");
#nullable restore
#line 74 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.CheckBoxFor(item => item.CanDownload));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (开启后会在首页显示APP下载的二维码)\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 2846, "\"", 2852, 0);
            EndWriteAttribute();
            WriteLiteral(">App版本号：</label>\r\n                <div class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 80 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.EditorFor(item => item.AppVersion, new { htmlAttributes = new { @class = "form-control input-sm" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""col-sm-4"">
                    <p class=""help-default"">版本号如：2.4.1</p>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-sm-2 control-label""");
            BeginWriteAttribute("for", " for=\"", 3299, "\"", 3305, 0);
            EndWriteAttribute();
            WriteLiteral(">AppleStore：</label>\r\n                <div class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 89 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.EditorFor(item => item.IOSDownLoad, new { htmlAttributes = new { @class = "form-control input-sm" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""col-sm-4"">
                    <p class=""help-default"">IOS版本下载地址</p>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-sm-2 control-label""");
            BeginWriteAttribute("for", " for=\"", 3756, "\"", 3762, 0);
            EndWriteAttribute();
            WriteLiteral(">Android：</label>\r\n                <div class=\"col-sm-3\">\r\n                    ");
#nullable restore
#line 98 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.EditorFor(item => item.AndriodDownLoad, new { htmlAttributes = new { @class = "form-control input-sm", @readOnly = "readOnly " } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-1 form-control-static\">\r\n                    <div class=\"divFile\">\r\n                        <input type=\"file\" id=\"btnFile\" class=\"inputFile\" name=\"file\"");
            BeginWriteAttribute("accept", " accept=\"", 4193, "\"", 4202, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""display:none;"" />
                        <input type=""button"" name=""button"" value=""选择文件"" style=""margin-top: -3px;"" onclick=""javascript:openBrowse();"" />
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <p class=""help-default"">Android版本安装包apk</p>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-sm-2 control-label""");
            BeginWriteAttribute("for", " for=\"", 4659, "\"", 4665, 0);
            EndWriteAttribute();
            WriteLiteral(">APP更新说明：</label>\r\n                <div class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 113 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.TextAreaFor(item => item.AppUpdateDescription, new { @class = "form-control input-sm", rows = 5 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 4986, "\"", 4992, 0);
            EndWriteAttribute();
            WriteLiteral(">第三方流量统计代码：</label>\r\n                <div class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 119 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.TextAreaFor(item => item.FlowScript, new { @class = "form-control input-sm", rows = 5 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <p class=\"help-default\">在商城（前台）各个页面加上第三方流量统计代码，用于记录各页面访问情况</p>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <h3 class=\"table-hd\">页脚设置</h3>\r\n            <div class=\"form-group\">\r\n                <div class=\"col-sm-offset-2 col-sm-10\">\r\n                    ");
#nullable restore
#line 137 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.TextAreaFor(item => item.PageFoot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <h3 class=\"table-hd\">SEO设置</h3>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 6299, "\"", 6305, 0);
            EndWriteAttribute();
            WriteLiteral(">Title：</label>\r\n                <div class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 146 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.EditorFor(item => item.Site_SEOTitle, new { htmlAttributes = new { @class = "form-control input-sm" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    <p class=\"help-default\"></p>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 6746, "\"", 6752, 0);
            EndWriteAttribute();
            WriteLiteral(">Keywords：</label>\r\n                <div class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 156 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.EditorFor(item => item.Site_SEOKeywords, new { htmlAttributes = new { @class = "form-control input-sm" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    <p class=\"help-default\"></p>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 7199, "\"", 7205, 0);
            EndWriteAttribute();
            WriteLiteral(">Description：</label>\r\n                <div class=\"col-sm-4\">\r\n                    ");
#nullable restore
#line 166 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.EditorFor(item => item.Site_SEODescription, new { htmlAttributes = new { @class = "form-control input-sm" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-4\">\r\n                    <p class=\"help-default\"></p>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <h3 class=\"table-hd\">会员注册</h3>\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 8091, "\"", 8097, 0);
            EndWriteAttribute();
            WriteLiteral(">注册方式：</label>\r\n                <div class=\"col-sm-8 form-control-static\">\r\n                    <label>");
#nullable restore
#line 183 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
                      Write(Html.RadioButton("RegisterType", "0", Model.RegisterType == Mall.CommonModel.RegisterTypes.Normal));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 普通账号</label>\r\n                    <label>");
#nullable restore
#line 184 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
                      Write(Html.RadioButton("RegisterType", "1", Model.RegisterType == Mall.CommonModel.RegisterTypes.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 手机注册</label>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\" id=\"regemailbox\">\r\n                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 8608, "\"", 8614, 0);
            EndWriteAttribute();
            WriteLiteral(">是否需要邮箱验证：</label>\r\n                <div class=\"col-sm-8 form-control-static\">\r\n                    ");
#nullable restore
#line 190 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
               Write(Html.CheckBoxFor(item => item.EmailVerifOpen));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (勾选邮箱验证后，会员注册需要经过邮箱验证！)\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 193 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
             if (Model.IsCanClearDemoData)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <h3 class=""table-hd"">一键清除演示数据</h3>
                <div class=""form-group"">
                    <h5 class=""tips-top mb0"" style=""margin-top:0;padding-bottom: 50px;""><span id=""btnClearData"">清除演示数据</span><span class=""help"">演示数据包括有演示店铺、演示店铺下的商品、门店，以及官方自营店铺中的演示商品。</span></h5>
                </div>
");
#nullable restore
#line 199 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"table-hd\">强制绑定手机号</h3>\r\n            <div class=\"form-group\">\r\n                <h5 class=\"tips-top mb0\" style=\"margin-top:0;\"><span class=\"help-default clear-d\"><i></i>提示：开启前请先进行短信相关配置。短信消息需要先 <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 9444, "\"", 9469, 1);
#nullable restore
#line 202 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
WriteAttributeValue("", 9451, ViewBag.LoginLink, 9451, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left:2px;\">购买短信</a></span></h5>\r\n");
            WriteLiteral("                <label class=\"col-sm-2 control-label\"");
            BeginWriteAttribute("for", " for=\"", 9764, "\"", 9770, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    开启强制绑定：\r\n                </label>\r\n");
            WriteLiteral("                <div class=\"col-sm-10\">\r\n                    <div class=\"onoffswitch\">\r\n                        <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 10298, "\"", 10331, 1);
#nullable restore
#line 217 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
WriteAttributeValue("", 10306, Model.IsConBindCellPhone, 10306, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"IsConBindCellPhone\" name=\"IsConBindCellPhone\" />\r\n                        <input formitem type=\"checkbox\" name=\"ckbIsOpenCellPhone\" ");
#nullable restore
#line 218 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
                                                                              Write(Model.IsConBindCellPhone ? "checked" : string.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" class=""onoffswitch-checkbox"" id=""ckbIsOpenCellPhone"">
                        <label class=""onoffswitch-label"" for=""ckbIsOpenCellPhone"">
                            <span class=""onoffswitch-inner""></span>
                            <span class=""onoffswitch-switch""></span>
                        </label>
                    </div>
                    <div class=""col-sm-5"">
                        <p class=""help-default"">开启后，在信任登录或进行购买时会强制要求绑定手机号</p>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <div class=""col-sm-offset-2 col-sm-10"">
                    <input type=""button"" id=""Save"" class=""btn btn-primary"" value=""保 存"" onclick=""SubmitInit()"">
                </div>
            </div>
        </div>
");
#nullable restore
#line 236 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11367, "\"", 11386, 1);
#nullable restore
#line 240 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
WriteAttributeValue("", 11375, Model.Logo, 11375, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Logo1\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11423, "\"", 11444, 1);
#nullable restore
#line 241 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
WriteAttributeValue("", 11431, Model.WXLogo, 11431, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"WXLogo1\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11483, "\"", 11508, 1);
#nullable restore
#line 242 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
WriteAttributeValue("", 11491, Model.MemberLogo, 11491, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"MemberLogo1\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11551, "\"", 11572, 1);
#nullable restore
#line 243 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
WriteAttributeValue("", 11559, Model.QRCode, 11559, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"QRCode1\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11611, "\"", 11636, 1);
#nullable restore
#line 244 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
WriteAttributeValue("", 11619, Model.PCLoginPic, 11619, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"PCLoginPic1\" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 11679, "\"", 11705, 1);
#nullable restore
#line 245 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\SiteSetting\Edit.cshtml"
WriteAttributeValue("", 11687, Model.PCBottomPic, 11687, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""PCBottomPic1"" />
<script>
    //提交前初始
    function SubmitInit() {
        var items = $('input[formItem]');
        var data;
        $.each(items, function (i, item) {
            if (item.type && item.type == 'checkbox') {
                data = item.checked;
            }
        });
        $(""#IsConBindCellPhone"").val(data);//开启强制绑定
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.Web.Models.SiteSettingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
