#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1a3d2b359d8ea910661c256a37cd0e39b507600"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Billing_ExportPlatAccountItems), @"mvc.1.0.view", @"/Areas/Admin/Views/Billing/ExportPlatAccountItems.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1a3d2b359d8ea910661c256a37cd0e39b507600", @"/Areas/Admin/Views/Billing/ExportPlatAccountItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdcb39a21de2ae84fe919284139b99d5fdc20b3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Billing_ExportPlatAccountItems : Mall.Web.Framework.WebViewPage<List<Mall.DTO.PlatAccountItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
  
	Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table cellspacing=""0"" cellpadding=""5"" rules=""all"" border=""1"">
	<thead>
		<tr>
			<th>ID</th>
			<th>
				时间
			</th>
			<th>
				资金流水号
			</th>
			<th>
				收支类型
			</th>
			<th>
				收入
			</th>
			<th>
				支出
			</th>
			<th>
				余额
			</th>
		</tr>
	</thead>
	<tbody id=""list-table-body"">
");
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td");
            BeginWriteAttribute("style", " style=\'", 432, "\'", 480, 2);
            WriteAttributeValue("", 440, "vnd.ms-excel.numberformat:", 440, 26, true);
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
WriteAttributeValue("", 466, Html.Raw("@"), 466, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
                                                                Write(item.Id.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 34 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
               Write(item.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td");
            BeginWriteAttribute("style", " style=\'", 546, "\'", 594, 2);
            WriteAttributeValue("", 554, "vnd.ms-excel.numberformat:", 554, 26, true);
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
WriteAttributeValue("", 580, Html.Raw("@"), 580, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
                                                                Write(item.AccountNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
               Write(item.AccountType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
               Write(item.Income);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 38 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
               Write(item.Expenditure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 39 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
               Write(item.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 41 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Billing\ExportPlatAccountItems.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mall.DTO.PlatAccountItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
