#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Templates\vshop\t2\Skin-HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d186a13a840e7d1e4375d00382fb2a9f451d612a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Templates_vshop_t2_Skin_HomePage), @"mvc.1.0.view", @"/Areas/Admin/Templates/vshop/t2/Skin-HomePage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d186a13a840e7d1e4375d00382fb2a9f451d612a", @"/Areas/Admin/Templates/vshop/t2/Skin-HomePage.cshtml")]
    public class Areas_Admin_Templates_vshop_t2_Skin_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/Scripts/WeiXinShare.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/Scripts/mui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/Scripts/AppAuto.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/Scripts/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/swipe-template.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/Mobile/Templates/Default/Scripts/IndexShare.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Templates\vshop\t2\Skin-HomePage.cshtml"
  
ViewBag.ShowAside = 2;//显示返回顶部按钮 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Templates\vshop\t2\Skin-HomePage.cshtml"
  Layout = "/Areas/Mobile/Templates/Default/Views/Shared/_Base.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n");
#nullable restore
#line 6 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Templates\vshop\t2\Skin-HomePage.cshtml"
  Html.RenderPartial("~/Areas/Mobile/Templates/Default/Views/Shared/_SearchBox.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://res.wx.qq.com/open/js/jweixin-1.0.0.js\"></script>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d186a13a840e7d1e4375d00382fb2a9f451d612a5874", async() => {
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
<link rel=""stylesheet"" href=""/Content/PublicMob/css/style.css"" />
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/css.css"" rev=""stylesheet"" type=""text/css"">
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/mycss.css"" rev=""stylesheet"" type=""text/css"">
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/main.css"" rev=""stylesheet"" type=""text/css"">
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/head.css"">

            <div class=""members_con"" style=""margin:10px auto"">
                
                <section class=""members_flash j-swipe"" id=""mySwipe"">
                    <ul class=""clearfix"">
                        
                        
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1147, "\"", 1154, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1155, "\"", 1163, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629341632421885492935.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1598, "\"", 1605, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1606, "\"", 1614, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629341561914063107972.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 2049, "\"", 2056, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2057, "\"", 2065, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629341594140637780082.jpg"" width=""100%"" />
                                
                                
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
         <script type=""text/javascript"">
                    $(function () {
                        $('html').css({
                            'height':'100%',
    ");
            WriteLiteral(@"                        'width':'100%'
                        })
                        $('body').css({
                            'height':'100%',
                            'width':'100%',
                            'background':'url(undefined) no-repeat',
                            'backgroundSize':'cover'
                        })
                    })
                </script>
            <div class=""members_con"">
                <section class=""members_nav1"">
                    <ul class=""pic-nav"">
                        
                        
                        
                        <li class=""lisw4"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629350429687507585110.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
        ");
            WriteLiteral(@"                <li class=""lisw4"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629350442089851313588.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                        <li class=""lisw4"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629350452539069812821.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                        <li class=""lisw4"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/");
            WriteLiteral(@"20151221/6358629350462402351784637.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                    </ul>
                </section>
            </div>
        
            <form action=""/m-Wap/search"" method=""get"">
                <div class=""members_con"">
                    <section class=""members_search"">
                        <input type=""text"" name=""keywords""");
            BeginWriteAttribute("id", " id=\"", 5661, "\"", 5666, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 5667, "\"", 5675, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""搜索"">
                        <label></label>
                    </section>
                </div>
            </form>
        
            <div class=""members_con"">
                <section class=""members_nav1"">
                    <ul class=""clearfix"">
                        
                        
                        
                        <li class=""board3 big_board
                    "">
                        <span>
                            <a href=""#"">
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629355893457036159443.jpg"">
                                
                            </a>
                        </span>
                    </li>
                        
                        
                        
                        <li class=""board3 
                    small_board"">
                        <span>
                            <a href=""#"">
              ");
            WriteLiteral(@"                  
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629355908398447415339.jpg"">
                                
                            </a>
                        </span>
                    </li>
                        
                        
                        
                        <li class=""board3 
                    small_board"">
                        <span>
                            <a href=""#"">
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629355923339857602308.jpg"">
                                
                            </a>
                        </span>
                    </li>
                        
                        
                        
                    </ul>
                </section>
            </div>
        
            <div class=""members_con"">
                <section class");
            WriteLiteral(@"=""members_special titlestyle0 center"">
                    <h2 class=""j-title"">
                        热卖精选
                    </h2>
                    <!--<p class=""j-subtitle"">『副标题』</p>-->
                    <!--
                        <b>更多</b>
                    -->
                </section>
            </div>
        
            <div class=""members_con"">
                <section class=""members_nav1"">
                    <ul class=""pic-nav"">
                        
                        
                        
                        <li class=""lisw2"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629362603710946893887.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                        <li class=""lisw2"">
                          ");
            WriteLiteral(@"  <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629362625488281594181.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                    </ul>
                </section>
            </div>
        
            <div class=""members_con"">
                <section class=""members_nav1"">
                    <ul class=""pic-nav"">
                        
                        
                        
                        <li class=""lisw2"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629362664648444008862.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                 ");
            WriteLiteral(@"       
                        
                        <li class=""lisw2"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629362561914065951789.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                    </ul>
                </section>
            </div>
        
            <div class=""members_con"">
                <section class=""members_special titlestyle0 center"">
                    <h2 class=""j-title"">
                        畅销商品
                    </h2>
                    <!--<p class=""j-subtitle"">『副标题』</p>-->
                    <!--
                        <b>更多</b>
                    -->
                </section>
            </div>
        
            <div class=""members_con"" style=""margin:0 auto"">
                
           ");
            WriteLiteral("     <section class=\"members_flash j-swipe\" id=\"mySwipe\">\n                    <ul class=\"clearfix\">\n                        \n                        \n                        <li>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 11005, "\"", 11012, 0);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 11013, "\"", 11021, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                
                                
                                <img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629381849414063994057.jpg"" width=""100%"" />
                                
                                
                            </a>
                        </li>
                        
                        
                    </ul>
                    <section class=""members_flash_time"">
                        
                    </section>
                </section>
                
            </div>
        
            <div class=""members_con"">
                <section class=""members_nav1"">
                    <ul class=""pic-nav"">
                        
                        
                        
                        <li class=""lisw2"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/635862937461015");
            WriteLiteral(@"6259677610.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                        <li class=""lisw2"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629374624218751933506.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                    </ul>
                </section>
            </div>
        
            <div class=""members_con"">
                <section class=""members_nav1"">
                    <ul class=""pic-nav"">
                        
                        
                        
                        <li class=""lisw2"">
                            <span><a class=""goodsimg"" href=""#""><div");
            WriteLiteral(@" class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629374637792974661984.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                        <li class=""lisw2"">
                            <span><a class=""goodsimg"" href=""#""><div class=""son""><img src=""http://2-2.Malltest.kuaidiantong.cn/Storage/template/0/20151221/6358629374648632818863045.jpg""></div></a></span>
                            <a class=""members_nav1_name"" href=""#""></a>
                        </li>
                        
                        
                        
                    </ul>
                </section>
            </div>
");
#nullable restore
#line 321 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Templates\vshop\t2\Skin-HomePage.cshtml"
          Html.RenderPartial("~/Areas/Mobile/Templates/Default/Views/Shared/_4ButtonsFoot.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<a class=\"WX-backtop\"></a>\n<a href=\"javascript:;\" class=\"btn_top\" ></a>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d186a13a840e7d1e4375d00382fb2a9f451d612a22641", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d186a13a840e7d1e4375d00382fb2a9f451d612a23679", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d186a13a840e7d1e4375d00382fb2a9f451d612a24717", async() => {
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
            WriteLiteral("\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d186a13a840e7d1e4375d00382fb2a9f451d612a25756", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d186a13a840e7d1e4375d00382fb2a9f451d612a26794", async() => {
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