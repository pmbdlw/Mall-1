#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b1c54d7f52ade679910f2ec222eaf165a376119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Web_Views_Home_HomeFloorDetail7), @"mvc.1.0.view", @"/Areas/Web/Views/Home/HomeFloorDetail7.cshtml")]
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
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
using Mall.Web.Framework;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b1c54d7f52ade679910f2ec222eaf165a376119", @"/Areas/Web/Views/Home/HomeFloorDetail7.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090c48694750ba7c62e752bf94ad67a159f3356f", @"/Areas/Web/Views/_ViewImports.cshtml")]
    public class Areas_Web_Views_Home_HomeFloorDetail7 : Mall.Web.Framework.WebViewPage<Mall.Web.Areas.Web.Models.HomeFloorModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
  
    var floor = Model;
    Mall.Web.Areas.Web.Models.HomeFloorModel.WebFloorProductLinks defaultModel = new Mall.Web.Areas.Web.Models.HomeFloorModel.WebFloorProductLinks()
    {
        ImageUrl = string.Empty,
        Url = "#"
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--楼层样式7-->\r\n<div class=\"floor floor-seven clearfix\">\r\n    <div class=\"floor-seven-hd\">\r\n        <h3>");
#nullable restore
#line 14 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
       Write(floor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <ul>\r\n            <li class=\"active\">");
#nullable restore
#line 16 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
                          Write(floor.DefaultTabName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<s></s></li>\r\n");
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
             foreach (var tab in floor.Tabs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 606, "\"", 614, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
                        Write(tab.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<s></s></li>\r\n");
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"floor-seven-top clearfix\">\r\n        <div class=\"fst-left\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 771, "\"", 875, 1);
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 778, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.LeftOne,defaultModel).Url, 778, 97, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 881, "\"", 989, 1);
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 887, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.LeftOne,defaultModel).ImageUrl, 887, 102, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n        </div>\r\n        <div class=\"fst-mid \">\r\n            <div class=\"fst-img-show tab-right current\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1123, "\"", 1229, 1);
#nullable restore
#line 29 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 1130, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleOne,defaultModel).Url, 1130, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1235, "\"", 1345, 1);
#nullable restore
#line 29 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 1241, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleOne,defaultModel).ImageUrl, 1241, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1373, "\"", 1479, 1);
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 1380, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleTwo,defaultModel).Url, 1380, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1485, "\"", 1595, 1);
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 1491, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleTwo,defaultModel).ImageUrl, 1491, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                <a class=\"fst-m-spe\"");
            BeginWriteAttribute("href", " href=\"", 1641, "\"", 1749, 1);
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 1648, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleThree,defaultModel).Url, 1648, 101, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1755, "\"", 1867, 1);
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 1761, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleThree,defaultModel).ImageUrl, 1761, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1895, "\"", 2002, 1);
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 1902, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleFour,defaultModel).Url, 1902, 100, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2008, "\"", 2119, 1);
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 2014, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleFour,defaultModel).ImageUrl, 2014, 105, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2147, "\"", 2254, 1);
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 2154, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleFive,defaultModel).Url, 2154, 100, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2260, "\"", 2371, 1);
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 2266, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleFive,defaultModel).ImageUrl, 2266, 105, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                <a class=\"fst-m-spe\"");
            BeginWriteAttribute("href", " href=\"", 2417, "\"", 2523, 1);
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 2424, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleSix,defaultModel).Url, 2424, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2529, "\"", 2639, 1);
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 2535, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.MiddleSix,defaultModel).ImageUrl, 2535, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n            </div>\r\n            <!--TAB-->\r\n");
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
             foreach (var tab in floor.Tabs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"tab-pro-show tab-right\" style=\"display:none;\">\r\n                    <ul>\r\n");
#nullable restore
#line 41 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
                         foreach (var item in tab.Detail)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <div>\r\n                                    <p><a");
            BeginWriteAttribute("href", " href=\"", 3056, "\"", 3094, 2);
            WriteAttributeValue("", 3063, "/Product/Detail/", 3063, 16, true);
#nullable restore
#line 45 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 3079, item.ProductId, 3079, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                                    <span>￥");
#nullable restore
#line 46 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <s>￥</s></span>\r\n                                </div>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3262, "\"", 3269, 0);
            EndWriteAttribute();
            WriteLiteral("><img class=\"lazyload\" src=\"Areas/Web/Images/integra-bg.png\" data-url=\"");
#nullable restore
#line 48 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
                                                                                                            Write(Mall.Core.MallIO.GetProductSizeImage(item.ImagePath, 1, (int)Mall.CommonModel.ImageSize.Size_150));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></a>\r\n                            </li>\r\n");
#nullable restore
#line 50 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n");
#nullable restore
#line 53 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"fst-right\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3638, "\"", 3739, 1);
#nullable restore
#line 56 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 3645, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.ROne,defaultModel).Url, 3645, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 3745, "\"", 3850, 1);
#nullable restore
#line 56 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 3751, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.ROne,defaultModel).ImageUrl, 3751, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3874, "\"", 3975, 1);
#nullable restore
#line 57 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 3881, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.RTwo,defaultModel).Url, 3881, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 3981, "\"", 4086, 1);
#nullable restore
#line 57 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 3987, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.RTwo,defaultModel).ImageUrl, 3987, 99, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4110, "\"", 4213, 1);
#nullable restore
#line 58 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 4117, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.RThree,defaultModel).Url, 4117, 96, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 4219, "\"", 4326, 1);
#nullable restore
#line 58 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 4225, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.RThree,defaultModel).ImageUrl, 4225, 101, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4350, "\"", 4452, 1);
#nullable restore
#line 59 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 4357, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.RFour,defaultModel).Url, 4357, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 4458, "\"", 4564, 1);
#nullable restore
#line 59 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 4464, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.RFour,defaultModel).ImageUrl, 4464, 100, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4588, "\"", 4690, 1);
#nullable restore
#line 60 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 4595, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.RFive,defaultModel).Url, 4595, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 4696, "\"", 4802, 1);
#nullable restore
#line 60 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 4702, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.RFive,defaultModel).ImageUrl, 4702, 100, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n        </div>\r\n    </div>\r\n    <div class=\"floor-seven-bottom clearfix\">\r\n        <div class=\"fsb-img-show tab-right current\">\r\n            <ul>\r\n                <li>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 5005, "\"", 5115, 1);
#nullable restore
#line 67 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 5011, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.BottomOne,defaultModel).ImageUrl, 5011, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </li>\r\n                <li>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 5190, "\"", 5300, 1);
#nullable restore
#line 70 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 5196, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.BottomTwo,defaultModel).ImageUrl, 5196, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </li>\r\n                <li>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 5375, "\"", 5487, 1);
#nullable restore
#line 73 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 5381, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.BottomThree,defaultModel).ImageUrl, 5381, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"fsb-pro-show tab-right\">\r\n            <ul>\r\n                <li>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 5661, "\"", 5771, 1);
#nullable restore
#line 80 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 5667, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.BottomOne,defaultModel).ImageUrl, 5667, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </li>\r\n                <li>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 5846, "\"", 5956, 1);
#nullable restore
#line 83 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 5852, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.BottomTwo,defaultModel).ImageUrl, 5852, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </li>\r\n                <li>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 6031, "\"", 6143, 1);
#nullable restore
#line 86 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Web\Views\Home\HomeFloorDetail7.cshtml"
WriteAttributeValue("", 6037, floor.Products.FirstOrDefault(e => e.Type == Mall.CommonModel.Position.BottomThree,defaultModel).ImageUrl, 6037, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.Web.Areas.Web.Models.HomeFloorModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
