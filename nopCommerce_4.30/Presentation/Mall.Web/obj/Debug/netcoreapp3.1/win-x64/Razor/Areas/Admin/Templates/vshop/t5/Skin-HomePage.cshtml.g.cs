#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Templates\vshop\t5\Skin-HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc528e4684894541c23b0135ff33aae9009effc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Templates_vshop_t5_Skin_HomePage), @"mvc.1.0.view", @"/Areas/Admin/Templates/vshop/t5/Skin-HomePage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc528e4684894541c23b0135ff33aae9009effc0", @"/Areas/Admin/Templates/vshop/t5/Skin-HomePage.cshtml")]
    public class Areas_Admin_Templates_vshop_t5_Skin_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/Scripts/WeiXinShare.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/Scripts/IndexShare.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/Scripts/mui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/Scripts/AppAuto.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/Scripts/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/swipe-template.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Templates\vshop\t5\Skin-HomePage.cshtml"
  
ViewBag.ShowAside = 2;//显示返回顶部按钮 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Templates\vshop\t5\Skin-HomePage.cshtml"
  Layout = "/Areas/Mobile/Templates/Default/Views/Shared/_Base.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n");
#nullable restore
#line 6 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Templates\vshop\t5\Skin-HomePage.cshtml"
  Html.RenderPartial("~/Areas/Mobile/Templates/Default/Views/Shared/_SearchBox.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://res.wx.qq.com/open/js/jweixin-1.0.0.js\"></script>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc528e4684894541c23b0135ff33aae9009effc05874", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc528e4684894541c23b0135ff33aae9009effc06911", async() => {
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
<link rel=""stylesheet"" href=""/Content/PublicMob/css/style.css"" />
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/css.css"" rev=""stylesheet"" type=""text/css"">
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/mycss.css"" rev=""stylesheet"" type=""text/css"">
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/main.css"" rev=""stylesheet"" type=""text/css"">
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/head.css"">

            <div class=""members_con"" style=""margin:0 auto"">
                
                <section class=""members_flash j-swipe"" id=""mySwipe"">
                    <ul class=""clearfix"">
                        
                        
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1223, "\"", 1230, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1231, "\"", 1239, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629498803125009395218.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1674, "\"", 1681, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1682, "\"", 1690, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629498838867191053236.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 2125, "\"", 2132, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2133, "\"", 2141, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629498866699228266855.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        
                    </ul>
                    <section class=""members_flash_time"">
                        
                        
                        <span class=""cur"" ></span>
                        
                        <span  ></span>
                        
                        <span  ></span>
                        
                        
                    </section>
                </section>
                
            </div>
        
            <div class=""members_con"">
                <section class=""members_nav1"">
                    <ul class=""pic-nav"">
                        
      ");
            WriteLiteral(@"                  
                        
                        <li class=""lisw3"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358631129046679693043007.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                        <li class=""lisw3"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358631128847851567616597.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                        <li class=""lisw3"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""htt");
            WriteLiteral(@"p://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358631128625683605260647.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                    </ul>
                </section>
            </div>
        
            <div class=""members_con"">
                <section class=""members_nav1"">
                    <ul class=""clearfix"">
                        
                        
                        
                        <li class=""board3 big_board
                    "">
                        <span>
                            <a href=""#"">
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629503927148444543970.jpg"">
                                
                            </a>
                        </span>
                    </li>
             ");
            WriteLiteral(@"           
                        
                        
                        <li class=""board3 
                    small_board"">
                        <span>
                            <a href=""#"">
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629504190234386369435.jpg"">
                                
                            </a>
                        </span>
                    </li>
                        
                        
                        
                        <li class=""board3 
                    small_board"">
                        <span>
                            <a href=""#"">
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629503951562501000927.jpg"">
                                
                            </a>
                        </span>
                    </li>");
            WriteLiteral(@"
                        
                        
                        
                    </ul>
                </section>
            </div>
        
            <div class=""members_con"" style=""margin:0 auto"">
                
                <section class=""members_imgad"">
                    <ul class=""clearfix"">
                        
                        
                        <li style=""margin-bottom:10px"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 6698, "\"", 6705, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 6706, "\"", 6714, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629506651855475352275.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li style=""margin-bottom:10px"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 7176, "\"", 7183, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 7184, "\"", 7192, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507825585946600005.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li style=""margin-bottom:10px"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 7654, "\"", 7661, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 7662, "\"", 7670, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507058789069406156.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li style=""margin-bottom:10px"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 8132, "\"", 8139, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 8140, "\"", 8148, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507844628917071054.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        
                    </ul>
                </section>
                
            </div>
        
            <div class=""members_con"" style=""margin:0 auto"">
                
                <section class=""members_imgad"">
                    <ul class=""clearfix"">
                        
                        
                        <li style=""margin-bottom:10px"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 8950, "\"", 8957, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 8958, "\"", 8966, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507067675787148727.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li style=""margin-bottom:10px"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 9428, "\"", 9435, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 9436, "\"", 9444, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507869531253528011.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li style=""margin-bottom:10px"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 9906, "\"", 9913, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 9914, "\"", 9922, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507076757818120542.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li style=""margin-bottom:10px"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 10384, "\"", 10391, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 10392, "\"", 10400, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507883105476256489.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li style=""margin-bottom:10px"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 10862, "\"", 10869, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 10870, "\"", 10878, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507085546889092358.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li style=""margin-bottom:10px"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 11340, "\"", 11347, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 11348, "\"", 11356, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507905566414186029.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        
                    </ul>
                </section>
                
            </div>
");
#nullable restore
#line 272 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Templates\vshop\t5\Skin-HomePage.cshtml"
          Html.RenderPartial("~/Areas/Mobile/Templates/Default/Views/Shared/_4ButtonsFoot.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<a class=\"WX-backtop\"></a>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc528e4684894541c23b0135ff33aae9009effc023091", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc528e4684894541c23b0135ff33aae9009effc024129", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc528e4684894541c23b0135ff33aae9009effc025167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc528e4684894541c23b0135ff33aae9009effc026206", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
