#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "915e9a99a225af355f2b05485b33e7c5ae62df87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_GoodGroup3), @"mvc.1.0.view", @"/Views/Shared/GoodGroup3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"915e9a99a225af355f2b05485b33e7c5ae62df87", @"/Views/Shared/GoodGroup3.cshtml")]
    public class Views_Shared_GoodGroup3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
  string renminbi = "￥";

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
Write(Html.Raw(Model.showWarp ? "<div class=\"members_con\"><section class=\"members_goodspic\"><ul id=\"" + Model.warpId + "\">" : ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
             if (@Model.list.Count > 0)
            {
                for (int i = 0; i < @Model.list.Count; i++)
                {

                    if (i % 3 == 0)
                    {
                        var goods = @Model.list[i];
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"biggoods\">\r\n                            <a class=\"goodsimg\"");
            BeginWriteAttribute("href", " href=\"", 504, "\"", 522, 1);
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 511, goods.link, 511, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "915e9a99a225af355f2b05485b33e7c5ae62df874706", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                                                              Write(goods.pic);

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
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                             if (@Model.showName || @Model.showPrice)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <section class=\"members_goodsimg_name rename\">\r\n");
#nullable restore
#line 16 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                     if (@Model.showName)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 952, "\"", 970, 1);
#nullable restore
#line 18 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 959, goods.link, 959, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 18 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                          Write(goods.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                     if (@Model.showIco)
                                    {
                                        if (goods.is_limitbuy)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i><a");
            BeginWriteAttribute("href", " href=\"", 1284, "\"", 1302, 1);
#nullable restore
#line 24 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 1291, goods.link, 1291, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">抢购</a></i>\r\n");
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"add-buy-btn j_productType\"");
            BeginWriteAttribute("productType", " productType=\"", 1528, "\"", 1560, 1);
#nullable restore
#line 28 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 1542, goods.productType, 1542, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a href=\"javascript:void(0)\" onclick=\"buyproduct(this)\" class=\"buyproduct\" data-pid=\"");
#nullable restore
#line 28 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                                                                                                                                                                  Write(goods.product_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">购买</a></i>\r\n");
#nullable restore
#line 29 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>\r\n\r\n");
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                         if (@Model.showPrice)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                       Write(renminbi);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                     ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                 Write(goods.price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                                  ;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"original_price\"><s>&yen;");
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                                            Write(goods.original_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</s></span>\r\n");
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span>\r\n");
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                     if (goods.ProductSaleCountOnOff)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>销量：<i>");
#nullable restore
#line 41 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                               Write(goods.SaleCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></span>\r\n");
#nullable restore
#line 42 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </section>\r\n");
#nullable restore
#line 44 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </li>\r\n");
#nullable restore
#line 46 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                    }
                    else if (i % 3 == 1)
                    {
                        var goods = @Model.list[i];
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"mingoods goods_even\">\r\n                            <a class=\"goodsimg\"");
            BeginWriteAttribute("href", " href=\"", 2768, "\"", 2786, 1);
#nullable restore
#line 51 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 2775, goods.link, 2775, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class =\"lazyload\" data-url=\"");
#nullable restore
#line 51 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                                                               Write(goods.pic);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", " src=\"", 2832, "\"", 2848, 1);
#nullable restore
#line 51 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 2838, goods.pic, 2838, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n");
#nullable restore
#line 52 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                             if (@Model.showIco || @Model.showPrice)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"replace\">\r\n");
#nullable restore
#line 56 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                     if (@Model.showName)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 3155, "\"", 3173, 1);
#nullable restore
#line 58 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 3162, goods.link, 3162, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 58 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                          Write(goods.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 59 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                     if (@Model.showIco)
                                    {
                                        if (goods.is_limitbuy)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i><a");
            BeginWriteAttribute("href", " href=\"", 3487, "\"", 3505, 1);
#nullable restore
#line 64 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 3494, goods.link, 3494, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">抢购</a></i>\r\n");
#nullable restore
#line 65 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"add-buy-btn j_productType\"");
            BeginWriteAttribute("productType", "  productType=\"", 3731, "\"", 3764, 1);
#nullable restore
#line 68 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 3746, goods.productType, 3746, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a href=\"javascript:void(0)\" onclick=\"buyproduct(this)\" class=\"buyproduct\" data-pid=\"");
#nullable restore
#line 68 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                                                                                                                                                                   Write(goods.product_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">购买</a></i>\r\n");
#nullable restore
#line 69 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                     if (@Model.showPrice)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                   Write(renminbi);

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                 ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                             Write(goods.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"original_price\"><s>&yen; ");
#nullable restore
#line 74 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                                         Write(goods.original_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</s></span>\r\n");
#nullable restore
#line 75 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </span>\r\n");
#nullable restore
#line 77 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                if (goods.ProductSaleCountOnOff)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"xl1\">销量：<i>");
#nullable restore
#line 79 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                       Write(goods.SaleCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></span>\r\n");
#nullable restore
#line 80 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </li>\r\n");
#nullable restore
#line 83 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"

                    }
                    else if (i % 3 == 2)
                    {
                        var goods = @Model.list[i];
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"mingoods goods_odd\">\r\n                            <a class=\"goodsimg\"");
            BeginWriteAttribute("href", " href=\"", 4854, "\"", 4872, 1);
#nullable restore
#line 89 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 4861, goods.link, 4861, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img class=\"lazyload\" data-url=\"");
#nullable restore
#line 89 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                                                              Write(goods.pic);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", " src=\"", 4917, "\"", 4933, 1);
#nullable restore
#line 89 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 4923, goods.pic, 4923, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n");
#nullable restore
#line 90 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                             if (@Model.showIco || @Model.showPrice)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"replace\">\r\n");
#nullable restore
#line 93 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                     if (@Model.showName)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 5238, "\"", 5256, 1);
#nullable restore
#line 95 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 5245, goods.link, 5245, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 95 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                          Write(goods.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 96 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                     if (@Model.showIco)
                                    {
                                        if (goods.is_limitbuy)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i><a");
            BeginWriteAttribute("href", " href=\"", 5570, "\"", 5588, 1);
#nullable restore
#line 101 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
WriteAttributeValue("", 5577, goods.link, 5577, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">抢购</a></i>\r\n");
#nullable restore
#line 102 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"add-buy-btn\"><a href=\"javascript:void(0)\" onclick=\"buyproduct(this)\" class=\"buyproduct\" data-pid=\"");
#nullable restore
#line 105 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                                                                                                                   Write(goods.product_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">购买</a></i>\r\n");
#nullable restore
#line 106 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                     if (@Model.showPrice)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                   Write(renminbi);

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                 ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                             Write(goods.price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                              ;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"original_price\"><s>&yen; ");
#nullable restore
#line 111 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                                         Write(goods.original_price);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</s></span>\r\n");
#nullable restore
#line 112 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </span>\r\n                                <span class=\"xl1\">销量：<i>");
#nullable restore
#line 114 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                                                   Write(goods.SaleCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></span>\r\n");
#nullable restore
#line 115 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </li>\r\n");
#nullable restore
#line 117 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
                    }
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 120 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\GoodGroup3.cshtml"
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