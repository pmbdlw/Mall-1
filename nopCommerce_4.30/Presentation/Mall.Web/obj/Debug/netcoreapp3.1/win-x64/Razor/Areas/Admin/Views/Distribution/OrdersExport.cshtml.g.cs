#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58ef8fac79a46664c1b93583bb58e0147d01594e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Distribution_OrdersExport), @"mvc.1.0.view", @"/Areas/Admin/Views/Distribution/OrdersExport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ef8fac79a46664c1b93583bb58e0147d01594e", @"/Areas/Admin/Views/Distribution/OrdersExport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdcb39a21de2ae84fe919284139b99d5fdc20b3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Distribution_OrdersExport : Mall.Web.Framework.WebViewPage<List<Mall.DTO.BrokerageOrder>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
   Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""1"">
    <thead>
        <tr>
            <th>订单编号</th>
            <th>商品名称</th>
            <th>店铺</th>
            <th>订单状态</th>
            <th>结算时间</th>
            <th>结算状态</th>
            <th>分销销售员</th>
            <th>佣金</th>
        </tr>
    </thead>
    <tbody id=""list-table-body"">
");
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td");
            BeginWriteAttribute("style", " style=\'", 503, "\'", 551, 2);
            WriteAttributeValue("", 511, "vnd.ms-excel.numberformat:", 511, 26, true);
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
WriteAttributeValue("", 537, Html.Raw("@"), 537, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
                                                            Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>");
            WriteLiteral("\r\n            <td>");
#nullable restore
#line 21 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>");
            WriteLiteral("\r\n            <td>");
#nullable restore
#line 22 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
           Write(item.ShopName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>");
            WriteLiteral("\r\n            <td>");
#nullable restore
#line 23 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
           Write(item.OrderStatusText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>");
            WriteLiteral("\r\n            <td>");
#nullable restore
#line 24 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
           Write(item.SettlementTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>");
            WriteLiteral("\r\n            <td>");
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
           Write(item.StatusText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>");
            WriteLiteral("\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
            Write(item.SuperiorId1 <= 0 ? "" : "一级:" + item.SuperiorName1);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 27 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
                                                                        Write(item.SuperiorId2 <= 0 ? "" : ",二级:" + item.SuperiorName2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
                                                                                                                                    Write(item.SuperiorId3 <= 0 ? "" : ",三级:" + item.SuperiorName3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>");
            WriteLiteral("            <td>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
            Write(item.SuperiorId1 <= 0 ? "" : "一级:" + item.Brokerage1.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
                                                                                    Write(item.SuperiorId2 <= 0 ? "" : ",二级:" + item.Brokerage2.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
                                                                                                                                                            Write(item.SuperiorId3 <= 0 ? "" : ",三级:" + item.Brokerage3.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Distribution\OrdersExport.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mall.DTO.BrokerageOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
