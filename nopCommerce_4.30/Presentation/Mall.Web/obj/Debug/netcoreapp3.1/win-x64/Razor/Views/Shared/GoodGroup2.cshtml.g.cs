#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18f79d9a7e9b93c7894dcd27ad14bdbcfb46d74b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_GoodGroup2), @"mvc.1.0.view", @"/Views/Shared/GoodGroup2.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f79d9a7e9b93c7894dcd27ad14bdbcfb46d74b", @"/Views/Shared/GoodGroup2.cshtml")]
    public class Views_Shared_GoodGroup2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("lazyload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/images/blank.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
  string renminbi = "￥";

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
Write(Html.Raw(Model.showWarp ? "<div class=\"members_con\"><section class=\"members_goodspic\"><ul id=\"" + Model.warpId + "\">" : ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                 if (@Model.list.Count > 0)
                {
                    for (int i = 0; i < @Model.list.Count; i++)
                    {
                        var good = @Model.list[i];
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"biggoods\">\r\n                            <a class=\"goodsimg\"");
            BeginWriteAttribute("href", " href=\"", 457, "\"", 474, 1);
#nullable restore
#line 9 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
WriteAttributeValue("", 464, good.link, 464, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "18f79d9a7e9b93c7894dcd27ad14bdbcfb46d74b4657", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                                                                             Write(good.pic);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-url", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n");
#nullable restore
#line 10 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                             if (@Model.showName || @Model.showPrice)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <section class=\"members_goodsimg_name rename\">\r\n");
#nullable restore
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                     if (@Model.showName)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 903, "\"", 920, 1);
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
WriteAttributeValue("", 910, good.link, 910, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                                         Write(good.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 16 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                     if (@Model.showIco)
                                        {
                                            if (good.is_limitbuy)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i><a");
            BeginWriteAttribute("href", " href=\"", 1248, "\"", 1265, 1);
#nullable restore
#line 21 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
WriteAttributeValue("", 1255, good.link, 1255, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">抢购</a></i>\r\n");
#nullable restore
#line 22 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i class=\"add-buy-btn j_productType\"");
            BeginWriteAttribute("productType", " productType=\"", 1507, "\"", 1538, 1);
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
WriteAttributeValue("", 1521, good.productType, 1521, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a href=\"javascript:void(0)\" onclick=\"buyproduct(this)\" class=\"buyproduct\" data-pid=\"");
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                                                                                                                                                                                     Write(good.product_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">购买</a></i>\r\n");
#nullable restore
#line 26 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>\r\n                                        \r\n");
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                         if (@Model.showPrice)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                       Write(renminbi);

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                                     ; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                                  Write(good.price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                                                  ;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"original_price\">原价：<s>&yen; ");
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                                                                Write(good.original_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</s></span>\r\n");
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span>\r\n");
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                     if (good.ProductSaleCountOnOff)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>销量：<i>");
#nullable restore
#line 38 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                               Write(good.SaleCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></span>\r\n");
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </section>\r\n");
#nullable restore
#line 41 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </li>\r\n");
#nullable restore
#line 43 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 45 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup2.cshtml"
           Write(Html.Raw(Model.showWarp ? "</ul></section></div>" : ""));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
