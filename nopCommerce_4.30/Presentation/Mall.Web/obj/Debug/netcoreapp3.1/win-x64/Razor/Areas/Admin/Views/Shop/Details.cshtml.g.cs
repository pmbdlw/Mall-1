#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f534538463fca05d8ee0a35c9317b98b176c896"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shop_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Shop/Details.cshtml")]
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
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Mall.CommonModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
using Mall.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f534538463fca05d8ee0a35c9317b98b176c896", @"/Areas/Admin/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fdcb39a21de2ae84fe919284139b99d5fdc20b3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shop_Details : Mall.Web.Framework.WebViewPage<Mall.Web.Models.ShopModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <ul class=""breadcrumb clearfix"">

        <li><a href=""./Management"">店铺管理</a></li>
        <li class=""active""><a>查看店铺详情</a></li>
    </ul>
	<div class=""queryDiv"">
		<img class=""queryImg"" src=""/Images/ic_query.png"">
		<div class=""tipBox"">
			<h5>温馨提示:</h5>
			<ul>
				<li><span>官方自营店默认拥有所有类目的经营权限，入驻商家需要申请经营类目。</span></li>
				<li><span>商家冻结后，商家将无法登录卖家中心，店铺所有商品都会下架， 商家下面的所有门店也会冻结。商家解冻后，所有商品需要重新上架，所有门店也需要重新解冻。</span></li>
			</ul>
		</div>
	</div>
    <div ");
#nullable restore
#line 22 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
     Write(Html.Raw(Model.BusinessType.Equals(Mall.CommonModel.ShopBusinessType.Enterprise) ? "" : "style='display:none;'"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@">
        <h3 class=""table-hd"">公司及联系人信息</h3>
        <table class=""table table-bordered table-striped"">
            <colgroup>
                <col class=""col-xs-1"">
                <col class=""col-xs-7"">
            </colgroup>
            <tbody>
                <tr>
                    <td>公司名称</td>
                    <td>");
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>公司所在地</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.CompanyRegion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>公司详细地址</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.CompanyAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>员工总数</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.CompanyEmployeeCount.ToDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>

        <h3 class=""table-hd"">营业执照信息（副本）</h3>
        <table class=""table table-bordered table-striped"">
            <colgroup>
                <col class=""col-xs-1"">
                <col class=""col-xs-7"">
            </colgroup>
            <tbody>
                <tr>
                    <td>营业执照号</td>
                    <td>");
#nullable restore
#line 58 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.BusinessLicenceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>法定经营范围</td>\r\n                    <td>");
#nullable restore
#line 62 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.BusinessSphere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 64 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                 if (!string.IsNullOrWhiteSpace(Model.BusinessLicenceNumberPhoto) && MallIO.ExistFile(Model.BusinessLicenceNumberPhoto))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>营业执照号<br />电子版</td>\r\n                        <td><img style=\"max-width:700px\"");
            BeginWriteAttribute("src", " src=\"", 2375, "\"", 2447, 1);
#nullable restore
#line 68 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
WriteAttributeValue("", 2381, Mall.Core.MallIO.GetImagePath(Model.BusinessLicenceNumberPhoto), 2381, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2448, "\"", 2454, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                    </tr>\r\n");
#nullable restore
#line 70 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>组织机构代码</td>\r\n                    <td>");
#nullable restore
#line 73 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.OrganizationCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 75 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                 if (!string.IsNullOrWhiteSpace(Model.OrganizationCodePhoto) && MallIO.ExistFile(Model.OrganizationCodePhoto))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>组织机构代码证<br />电子版</td>\r\n                        <td><img style=\"max-width:700px\"");
            BeginWriteAttribute("src", " src=\"", 2927, "\"", 2994, 1);
#nullable restore
#line 79 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
WriteAttributeValue("", 2933, Mall.Core.MallIO.GetImagePath(Model.OrganizationCodePhoto), 2933, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2995, "\"", 3001, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                    </tr>\r\n");
#nullable restore
#line 81 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n");
#nullable restore
#line 85 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
         if (!string.IsNullOrEmpty(Model.BusinessLicenseCert))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h3 class=""table-hd"">经营许可类证书</h3>
            <table class=""table table-bordered table-striped"">
                <colgroup>
                    <col class=""col-xs-1"">
                    <col class=""col-xs-7"">
                </colgroup>
                <tbody>

");
#nullable restore
#line 95 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                     for (int i = 1; i < 4; i++)
                    {
                        if (Mall.Core.MallIO.ExistFile(Model.BusinessLicenseCert + string.Format("{0}.png", i)))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><img style=\"max-width:700px\"");
            BeginWriteAttribute("src", " src=\"", 3770, "\"", 3865, 1);
#nullable restore
#line 100 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
WriteAttributeValue("", 3776, Mall.Core.MallIO.GetImagePath(Model.BusinessLicenseCert + string.Format("{0}.png", i)), 3776, 89, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3866, "\"", 3872, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                            </tr>\r\n");
#nullable restore
#line 102 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 106 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
         if (!string.IsNullOrEmpty(Model.ProductCert))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h3 class=""table-hd"">产品类证书</h3>
            <table class=""table table-bordered table-striped"">
                <colgroup>
                    <col class=""col-xs-1"">
                    <col class=""col-xs-7"">
                </colgroup>
                <tbody>
");
#nullable restore
#line 116 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                     for (int i = 1; i < 4; i++)
                    {
                        if (Mall.Core.MallIO.ExistFile(Model.ProductCert + string.Format("{0}.png", i)))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><img style=\"max-width:700px\"");
            BeginWriteAttribute("src", " src=\"", 4677, "\"", 4764, 1);
#nullable restore
#line 121 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
WriteAttributeValue("", 4683, Mall.Core.MallIO.GetImagePath(Model.ProductCert + string.Format("{0}.png", i)), 4683, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4765, "\"", 4771, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                            </tr>\r\n");
#nullable restore
#line 123 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 127 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 130 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
         if (!string.IsNullOrEmpty(Model.OtherCert))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h3 class=""table-hd"">其它证书</h3>
            <table class=""table table-bordered table-striped"">
                <colgroup>
                    <col class=""col-xs-1"">
                    <col class=""col-xs-7"">
                </colgroup>
                <tbody>
");
#nullable restore
#line 139 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                     for (int i = 1; i < 4; i++)
                    {
                        if (Mall.Core.MallIO.ExistFile(Model.OtherCert + string.Format("{0}.png", i)))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><img style=\"max-width:700px\"");
            BeginWriteAttribute("src", " src=\"", 5575, "\"", 5660, 1);
#nullable restore
#line 144 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
WriteAttributeValue("", 5581, Mall.Core.MallIO.GetImagePath(Model.OtherCert + string.Format("{0}.png", i)), 5581, 79, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5661, "\"", 5667, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                            </tr>\r\n");
#nullable restore
#line 146 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 150 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
 if (!string.IsNullOrWhiteSpace(Model.GeneralTaxpayerPhot) && MallIO.ExistFile(Model.GeneralTaxpayerPhot))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h3 class=""table-hd"">一般纳税人证明</h3>
        <table class=""table table-bordered table-striped"">
            <colgroup>
                <col class=""col-xs-1"">
                <col class=""col-xs-7"">
            </colgroup>
            <tbody>
                <tr>
                    <td>一般纳税人证明</td>
                    <td><img style=""max-width:700px""");
            BeginWriteAttribute("src", " src=\"", 6306, "\"", 6371, 1);
#nullable restore
#line 162 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
WriteAttributeValue("", 6312, Mall.Core.MallIO.GetImagePath(Model.GeneralTaxpayerPhot), 6312, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6372, "\"", 6378, 0);
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 166 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div ");
#nullable restore
#line 169 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
     Write(Html.Raw(Model.BusinessType.Equals(Mall.CommonModel.ShopBusinessType.Enterprise) ? "style='display:none;'" : ""));

#line default
#line hidden
#nullable disable
            WriteLiteral(@">
        <h3 class=""table-hd"">个人入驻信息</h3>
        <table class=""table table-bordered table-striped"">
            <colgroup>
                <col class=""col-xs-1"">
                <col class=""col-xs-7"">
            </colgroup>
            <tbody>
                <tr>
                    <td>姓名</td>
                    <td>");
#nullable restore
#line 179 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>住址</td>\r\n                    <td>");
#nullable restore
#line 183 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.CompanyRegion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>详细地址</td>\r\n                    <td>");
#nullable restore
#line 187 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.CompanyAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>
        <h3 class=""table-hd"">身份信息</h3>
        <table class=""table table-bordered table-striped"">
            <colgroup>
                <col class=""col-xs-1"">
                <col class=""col-xs-7"">
            </colgroup>
            <tbody>
                <tr>
                    <td>身份证号码</td>
                    <td>");
#nullable restore
#line 200 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.IDCard);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<td>身份证正面照</td>\r\n\t\t\t\t\t<td><img");
            BeginWriteAttribute("src", " src=\"", 7696, "\"", 7741, 1);
#nullable restore
#line 204 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
WriteAttributeValue("", 7702, MallIO.GetImagePath(Model.IDCardUrl), 7702, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n\t\t\t\t</tr>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<td>身份证背面照</td>\r\n\t\t\t\t\t<td><img");
            BeginWriteAttribute("src", " src=\"", 7806, "\"", 7852, 1);
#nullable restore
#line 208 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
WriteAttributeValue("", 7812, MallIO.GetImagePath(Model.IDCardUrl2), 7812, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></td>
				</tr>
            </tbody>
        </table>
    </div>

    <h3 class=""table-hd"">银行账户</h3>
    <table class=""table table-bordered table-striped"">
        <colgroup>
            <col class=""col-xs-1"">
            <col class=""col-xs-7"">
        </colgroup>
        <tbody>
            <tr>
                <td>银行开户名</td>
                <td>");
#nullable restore
#line 223 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
               Write(Model.BankAccountName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>公司银行账号</td>\r\n                <td>");
#nullable restore
#line 227 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
               Write(Model.BankAccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>开户银行支行名称</td>\r\n                <td>");
#nullable restore
#line 231 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
               Write(Model.BankName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>支行联行号</td>\r\n                <td>");
#nullable restore
#line 235 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
               Write(Model.BankCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>开户银行所在地</td>\r\n                <td>");
#nullable restore
#line 239 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
               Write(Model.BankRegionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n    <div ");
#nullable restore
#line 244 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
     Write(Html.Raw(Model.WeiXinOpenId != null && !Model.WeiXinOpenId.Equals("") ? "" : "style='display:none;'"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@">
        <h3 class=""table-hd"">微信账户</h3>
        <table class=""table table-bordered table-striped"">
            <colgroup>
                <col class=""col-xs-1"">
                <col class=""col-xs-7"">
            </colgroup>
            <tbody>
                <tr>
                    <td>收款微信昵称</td>
                    <td>");
#nullable restore
#line 254 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.WeiXinNickName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>性别</td>\r\n                    <td>");
#nullable restore
#line 258 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                    Write(Model.WeiXinSex.Equals(0) ? "女" : "男");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>所在地区</td>\r\n                    <td>");
#nullable restore
#line 262 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.WeiXinAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>真实姓名</td>\r\n                    <td>");
#nullable restore
#line 266 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Model.WeiXinTrueName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
            </tbody>
        </table>
    </div>

    <h3 class=""table-hd"">店铺经营信息</h3>
    <table class=""table table-bordered table-striped"">
        <colgroup>
            <col class=""col-xs-1"">
            <col class=""col-xs-7"">
        </colgroup>
        <tbody>
            <tr>
                <td>卖家帐号</td>
                <td>");
#nullable restore
#line 281 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
               Write(Model.Account);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>店铺名称</td>\r\n                <td>");
#nullable restore
#line 285 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>店铺等级</td>\r\n                <td>");
#nullable restore
#line 289 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
               Write(Model.ShopGrade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>店铺有效期</td>\r\n                <td>");
#nullable restore
#line 293 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                Write(Model.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            </tr>
        </tbody>
    </table>
    <h3 class=""table-hd"">经营类目</h3>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>商品类目</th>
                <th>分佣比例</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 306 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
             foreach (var item in Model.BusinessCategory)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 309 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 310 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
                   Write(Math.Round(item.CommisRate, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</td>\r\n                </tr>\r\n");
#nullable restore
#line 312 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </tbody>
    </table>

    <h3 class=""table-hd"">平台审核信息</h3>
    <table class=""table table-bordered table-striped"">
        <colgroup>
            <col class=""col-xs-1"">
            <col class=""col-xs-7"">
        </colgroup>
        <tbody>
            <tr>
                <td>审核状态</td>
                <td>");
#nullable restore
#line 326 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Admin\Views\Shop\Details.cshtml"
               Write(ViewBag.PassStr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mall.Web.Models.ShopModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
