#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Product\ProductComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4277e3f87085b6c45ffa8ab6078e229f5259c37e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Web_Views_Product_ProductComment), @"mvc.1.0.view", @"/Areas/Web/Views/Product/ProductComment.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Web.Areas.SellerAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Web.Areas.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\_ViewImports.cshtml"
using Mall.CommonModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4277e3f87085b6c45ffa8ab6078e229f5259c37e", @"/Areas/Web/Views/Product/ProductComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090c48694750ba7c62e752bf94ad67a159f3356f", @"/Areas/Web/Views/_ViewImports.cshtml")]
    public class Areas_Web_Views_Product_ProductComment : Mall.Web.Framework.WebViewPage<Mall.Entities.ProductInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Product\ProductComment.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""right"">
    <div id=""product-detail"" class=""m m2"">
        <div class=""float-nav-wrap"">
            <div class=""mt"">
                <ul class=""tab"">
                    <li class=""curr goods-li""><span><a href=""javascript:;"" class=""toggle-link"">商品介绍</a></span></li>
                    <li class=""comment-li""><a href=""javascript:;"" class=""toggle-link"">商品评价<span id=""CommentsU"" class=""hl_blue""> 0 </span></a></li>
                    <li class=""consult-li""><a href=""javascript:;"" class=""toggle-link"">商品咨询<span id=""ConsU"" class=""hl_blue""> 0 </span></a></li>
                </ul>
            </div>
        </div>
        <div class=""mc"" id=""product-detail-1"">
            <ul class=""detail-list"" id=""detail-list"">
                <li");
            BeginWriteAttribute("title", " title=\"", 818, "\"", 826, 0);
            EndWriteAttribute();
            WriteLiteral(">商品名称：");
#nullable restore
#line 18 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Product\ProductComment.cshtml"
                             Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Product\ProductComment.cshtml"
                 if (!string.IsNullOrWhiteSpace(Model.ProductCode))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>商品货号：");
#nullable restore
#line 21 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Product\ProductComment.cshtml"
                    Write(Model.ProductCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
#nullable restore
#line 21 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Product\ProductComment.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Product\ProductComment.cshtml"
                 if (!string.IsNullOrWhiteSpace(Model.BrandName))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>品牌：");
#nullable restore
#line 24 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Product\ProductComment.cshtml"
                  Write(Model.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
#nullable restore
#line 24 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Product\ProductComment.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"     
            </ul>
            <div id=""product-html"" style=""position:relative""></div>
        </div>
    </div>
    <!--product-detail end-->
    <div id=""comment"" class=""m m1"">
        <div class=""mc"">
            <div id=""i-comment"">
                <div class=""rate"">
                    <strong>100%</strong> <br />
                    <span>好评度</span>
                </div>
                <div class=""percent"">
                    <dl>
                        <dt>好评<span>(100%)</span></dt>
                        <dd>
                            <div style=""width: 100px;""></div>
                        </dd>
                    </dl>
                    <dl>
                        <dt>中评<span>(0%)</span></dt>
                        <dd class=""d1"">
                            <div style=""width: 0%;""> </div>
                        </dd>
                    </dl>
                    <dl>
                        <dt>差评<span>(0%)</span></dt>
                        <dd class");
            WriteLiteral(@"=""d1"">
                            <div style=""width: 0%;""> </div>
                        </dd>
                    </dl>
                </div>
            </div>
        </div>
    </div>
    <!--comment end-->

    <div id=""comments-list"" class=""m"">
        <ul class=""tab"" id=""id_comment_btn"">
            <li class=""active""><a href=""javascript:;"">全部评价<em id=""totalComment""></em></a></li>
            <li><a href=""javascript:;"">好评<em id=""goodComment""></em></a></li>
            <li><a href=""javascript:;"">中评<em");
            BeginWriteAttribute("id", " id=\"", 2683, "\"", 2688, 0);
            EndWriteAttribute();
            WriteLiteral(@"></em></a></li>
            <li><a href=""javascript:;"">差评<em id=""badComment""></em></a></li>
            <li><a href=""javascript:;"">有图<em id=""hasImages""></em></a></li>
            <li><a href=""javascript:;"">追加评论<em id=""hasAppend""></em></a></li>
            <li class=""tab-last""></li>
        </ul>
    </div>

    <!--comment end-->
    <div id=""consult"" class=""m m2"">
        <div class=""mt"">
            <ul class=""tab"">
                <li><a href=""javascript:;"">商品咨询</a></li>
            </ul>
            <div class=""consult-pub""> <a");
            BeginWriteAttribute("href", " href=\"", 3240, "\"", 3323, 2);
#nullable restore
#line 81 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Product\ProductComment.cshtml"
WriteAttributeValue("", 3247, Url.Action("index", "ProductConsultation" , new { id=Model.Id}), 3247, 64, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3311, "#ConsultForm", 3311, 12, true);
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">我要咨询</a> </div>
        </div>
        <div id=""consult-search"">
            <div class=""prompt""> <strong>温馨提示: </strong>因厂家更改产品包装、产地或者更换随机附件等没有任何提前通知，且每位咨询者购买情况、提问时间等不同，为此以下回复仅对提问者3天内有效，其他网友仅供参考！若由此给您带来不便请多多谅解，谢谢！ </div>
        </div>
        <!--consult-search end-->
        <div id=""consult-0"" class=""mc tabcon"" data-widget=""tab-content"">
        </div>
    </div>
    <!--consult end-->
    
    <!-- 相关商品 -->
    <div class=""clearfix"" style=""display:none;"">
        <div class=""relation-title"">猜你喜欢</div>
        <div id=""relationProducts"">
            <template>
                <a class=""relation-pro""");
            BeginWriteAttribute("href", " href=\"", 3967, "\"", 4025, 2);
#nullable restore
#line 97 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Product\ProductComment.cshtml"
WriteAttributeValue("", 3974, Url.Action("detail",new { id=(object)null}), 3974, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4018, "/{{id}}", 4018, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""relation-pro-img"">
                        <img src=""{{imagePath}}"" />
                    </div>                    
                    <p class=""relation-pro-price""><i>￥</i>{{minSalePrice}}</p>
                    <p class=""relation-pro-name"">{{productName}}</p>
                </a>                
            </template>
        </div>
    </div>
    
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.Entities.ProductInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591