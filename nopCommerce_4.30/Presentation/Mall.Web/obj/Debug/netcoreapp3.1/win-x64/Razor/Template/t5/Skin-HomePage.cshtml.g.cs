#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Template\t5\Skin-HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82fa1456f03737fe90bf2b57612bd826d322ec1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Template_t5_Skin_HomePage), @"mvc.1.0.view", @"/Template/t5/Skin-HomePage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82fa1456f03737fe90bf2b57612bd826d322ec1c", @"/Template/t5/Skin-HomePage.cshtml")]
    public class Template_t5_Skin_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/Scripts/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/swipe-template.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Template\t5\Skin-HomePage.cshtml"
  Layout = "/Areas/Mobile/Templates/Default/Views/Shared/_Base.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Template\t5\Skin-HomePage.cshtml"
  
    long curshopid = (long)ViewBag.ShopId, curvshopid = (long)ViewBag.VshopId;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    ");
#nullable restore
#line 6 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Template\t5\Skin-HomePage.cshtml"
Write(Html.RenderAction("VShopHeader", "vshop", new { id = curvshopid }));

#line default
#line hidden
#nullable disable
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
            BeginWriteAttribute("href", " href=\"", 955, "\"", 962, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 963, "\"", 971, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                        <img src=\"http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629498803125009395218.jpg\" width=\"100%\" />\r\n\r\n\r\n                    </a>\r\n                </li>\r\n\r\n                <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1224, "\"", 1231, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1232, "\"", 1240, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                        <img src=\"http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629498838867191053236.jpg\" width=\"100%\" />\r\n\r\n\r\n                    </a>\r\n                </li>\r\n\r\n                <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1493, "\"", 1500, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1501, "\"", 1509, 0);
            EndWriteAttribute();
            WriteLiteral(@">


                        <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629498866699228266855.jpg"" width=""100%"" />


                    </a>
                </li>


            </ul>
            <section class=""members_flash_time"">


                <span class=""cur""></span>

                <span></span>

                <span></span>


            </section>
        </section>

    </div>

    <div class=""members_con"">
        <section class=""members_nav1"">
            <ul class=""pic-nav"">



                <li class=""lisw3"">
                    <span><a href=""#""><img class=""img-responsive"" src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358631129046679693043007.jpg""></a></span>
                    <a class=""members_nav1_name"" href=""#""></a>
                </li>



                <li class=""lisw3"">
                    <span><a href=""#""><img class=""img-responsive"" src=""http://2-2.Malltest.kuaidiantong.cn/Storag");
            WriteLiteral(@"e/template/0/20151221/6358631128847851567616597.jpg""></a></span>
                    <a class=""members_nav1_name"" href=""#""></a>
                </li>



                <li class=""lisw3"">
                    <span><a href=""#""><img class=""img-responsive"" src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358631128625683605260647.jpg""></a></span>
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



                <li class=""boa");
            WriteLiteral(@"rd3
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
                </li>



            </ul>
        </section>
    </div>

    <div class=""members_con"" style=""margin:0 auto"">

        <section class=""members_imgad"">
            <ul class=""clearfix"">


                <li style=""margin-bottom:10px"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 4513, "\"", 4520, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4521, "\"", 4529, 0);
            EndWriteAttribute();
            WriteLiteral(@">


                        <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629506651855475352275.jpg"" width=""100%"" />


                    </a>
                </li>

                <li style=""margin-bottom:10px"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 4809, "\"", 4816, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4817, "\"", 4825, 0);
            EndWriteAttribute();
            WriteLiteral(@">


                        <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507825585946600005.jpg"" width=""100%"" />


                    </a>
                </li>

                <li style=""margin-bottom:10px"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 5105, "\"", 5112, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 5113, "\"", 5121, 0);
            EndWriteAttribute();
            WriteLiteral(@">


                        <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507058789069406156.jpg"" width=""100%"" />


                    </a>
                </li>

                <li style=""margin-bottom:10px"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 5401, "\"", 5408, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 5409, "\"", 5417, 0);
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
            BeginWriteAttribute("href", " href=\"", 5889, "\"", 5896, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 5897, "\"", 5905, 0);
            EndWriteAttribute();
            WriteLiteral(@">


                        <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507067675787148727.jpg"" width=""100%"" />


                    </a>
                </li>

                <li style=""margin-bottom:10px"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 6185, "\"", 6192, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 6193, "\"", 6201, 0);
            EndWriteAttribute();
            WriteLiteral(@">


                        <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507869531253528011.jpg"" width=""100%"" />


                    </a>
                </li>

                <li style=""margin-bottom:10px"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 6481, "\"", 6488, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 6489, "\"", 6497, 0);
            EndWriteAttribute();
            WriteLiteral(@">


                        <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507076757818120542.jpg"" width=""100%"" />


                    </a>
                </li>

                <li style=""margin-bottom:10px"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 6777, "\"", 6784, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 6785, "\"", 6793, 0);
            EndWriteAttribute();
            WriteLiteral(@">


                        <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507883105476256489.jpg"" width=""100%"" />


                    </a>
                </li>

                <li style=""margin-bottom:10px"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 7073, "\"", 7080, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 7081, "\"", 7089, 0);
            EndWriteAttribute();
            WriteLiteral(@">


                        <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629507085546889092358.jpg"" width=""100%"" />


                    </a>
                </li>

                <li style=""margin-bottom:10px"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 7369, "\"", 7376, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 7377, "\"", 7385, 0);
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
#line 268 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Template\t5\Skin-HomePage.cshtml"
      Html.RenderPartial("~/Areas/Mobile/Templates/Default/Views/Shared/_4ButtonsFoot_shop.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<a class=\"WX-backtop\"></a>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fa1456f03737fe90bf2b57612bd826d322ec1c15206", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82fa1456f03737fe90bf2b57612bd826d322ec1c16246", async() => {
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
            WriteLiteral("\r\n\r\n");
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