#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ff9f41a1cea5e579170d50904a2646df1a93a0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mobile_Templates_Default_Views_Order_ChooseShippingAddress), @"mvc.1.0.view", @"/Areas/Mobile/Templates/Default/Views/Order/ChooseShippingAddress.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 10 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\_ViewImports.cshtml"
using Mall.CommonModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
using Mall.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff9f41a1cea5e579170d50904a2646df1a93a0f", @"/Areas/Mobile/Templates/Default/Views/Order/ChooseShippingAddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"251375f151a8ed74fad18b07a59f5490bcea9ba2", @"/Areas/Mobile/Templates/Default/Views/_ViewImports.cshtml")]
    public class Areas_Mobile_Templates_Default_Views_Order_ChooseShippingAddress : Mall.Web.Framework.MobileWebViewPage<List<Mall.Entities.ShippingAddressInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
  
    ViewBag.Title = "收货地址管理";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container ShippingAddress\">\r\n    <ul class=\"list-group address\">\r\n");
#nullable restore
#line 10 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("id", " id=\"", 254, "\"", 267, 1);
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 259, item.Id, 259, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("shipto", " shipto=\"", 268, "\"", 289, 1);
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 277, item.ShipTo, 277, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("phone", " phone=\"", 290, "\"", 309, 1);
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 298, item.Phone, 298, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("regionfullname", " regionfullname=\"", 310, "\"", 347, 1);
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 327, item.RegionFullName, 327, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("address", " address=\"", 348, "\"", 371, 1);
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 358, item.Address, 358, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("regionid", " regionid=\"", 372, "\"", 397, 1);
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 383, item.RegionId, 383, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("latAndLng", " latAndLng=\"", 398, "\"", 445, 1);
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 410, item.Latitude+","+item.Longitude, 410, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("addressDetail", " addressDetail=\"", 446, "\"", 521, 1);
#nullable restore
#line 12 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 462, item.AddressDetail!=null?item.AddressDetail:string.Empty, 462, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"add-info\"");
            BeginWriteAttribute("editId", " editId=\"", 562, "\"", 579, 1);
#nullable restore
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 571, item.Id, 571, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("isNeedUpdate", " isNeedUpdate=\"", 580, "\"", 611, 1);
#nullable restore
#line 13 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 595, item.NeedUpdate, 595, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 637, "\"", 676, 3);
            WriteAttributeValue("", 645, "glyphicon", 645, 9, true);
            WriteAttributeValue(" ", 654, "glyphicon-ok-", 655, 14, true);
#nullable restore
#line 14 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 668, item.Id, 668, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                    <h6>");
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                   Write(item.ShipTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 15 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                                      Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                    <p>");
#nullable restore
#line 16 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                   Write(item.RegionFullName + " " + item.Address + " " + (item.AddressDetail != null ? item.AddressDetail : string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                     if (item.NeedUpdate)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"toUpdate edit\"");
            BeginWriteAttribute("editId", " editId=\"", 1013, "\"", 1030, 1);
#nullable restore
#line 19 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 1022, item.Id, 1022, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i></i>\r\n                            <h6>需要升级</h6>\r\n                        </div>\r\n");
#nullable restore
#line 23 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"cho-addr\">\r\n");
#nullable restore
#line 26 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                     if (item.IsDefault)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <lable><span class=\"default active\"></span>默认</lable>\r\n");
#nullable restore
#line 29 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span class=\"cho-btn\">\r\n");
#nullable restore
#line 32 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                         if (!item.IsDefault)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"edit editSetDefault\">设为默认</a>\r\n");
#nullable restore
#line 35 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1655, "\"", 1683, 3);
            WriteAttributeValue("", 1665, "EditAddr(", 1665, 9, true);
#nullable restore
#line 36 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 1674, item.Id, 1674, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1682, ")", 1682, 1, true);
            EndWriteAttribute();
            WriteLiteral(">编辑</a>\r\n                        <a class=\"del\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1731, "\"", 1766, 3);
            WriteAttributeValue("", 1741, "DeleteAddr(this,", 1741, 16, true);
#nullable restore
#line 37 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
WriteAttributeValue("", 1757, item.Id, 1757, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1765, ")", 1765, 1, true);
            EndWriteAttribute();
            WriteLiteral(">删除</a>\r\n                    </span>\r\n\r\n                </div>\r\n            </li>");
#nullable restore
#line 41 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <footer class=\"clearfix\">\r\n        <a class=\"add-footer\" onclick=\"EditAddr(0)\"><i class=\"glyphicon glyphicon-plus\"></i> 新增收货地址</a>\r\n    </footer>\r\n</div>\r\n\r\n<script>\r\n    var chooseUrl = \'");
#nullable restore
#line 49 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                Write(Url.Action("SetDefaultUserShippingAddress"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var setDefaultUrl = \'");
#nullable restore
#line 50 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                    Write(Url.Action("SetDefaultUserShippingAddress"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var editUrl = \'");
#nullable restore
#line 51 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
              Write(Url.Action("EditShippingAddress"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var deleteUrl = \'");
#nullable restore
#line 52 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                Write(Url.Action("DeleteShippingAddress"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    var cacheKey = 'ChoseShippingAddress.Value';

    $(function () {
        $("".address"").on(""click"", "".toUpdate"", function () {
            ToUpdate($(this).attr(""editId""));
            return false;
        }).on(""click"", "".add-info"", function () {
            SetDefault($(this).attr(""editId""),$(this).attr(""isNeedUpdate""));
            }).on(""click"", "".editSetDefault"", function () {
                SetDefault($(this).parents("".cho-addr"").siblings("".add-info"").attr(""editId""), $(this).parents("".cho-addr"").siblings("".add-info"").attr(""isNeedUpdate""));
        });
    });

    function ChooseAddr(addId, needUpdate) {
        if (needUpdate) { $.dialog.errorTips('地址库已更新，收货地址需要升级'); return; }
        //      $("".glyphicon-ok-'"" + addId + ""'"").addClass(""active"");
        $.post(chooseUrl, { addId: addId }, function (result) {
            if (result.success) {
                //window.location.reload();
                saveAndGoBack(addId);
            }
        });
    }

    function ");
            WriteLiteral(@"SetDefault(addId,needUpdate) {
        if (needUpdate) { $.dialog.errorTips('地址库已更新，收货地址需要升级'); return; }
        var loading = showLoading();
        $("".glyphicon-ok-'"" + addId + ""'"").addClass(""active"");
        $.post(setDefaultUrl, { addId: addId }, function (result) {
            loading.close();
            if (result.success)
                saveAndGoBack(addId);
        });
    }

    function ToUpdate(editId) {
        var isOrder = QueryString('isOrder');
        if (isOrder) {
            window.location.href = editUrl + '?addressId=' + editId + '&isOrder=' + isOrder + ""&isUpdate=1&returnUrl=");
#nullable restore
#line 91 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                                                                                                                Write(HttpUtility.UrlEncode(Context.Request.GetDisplayUrl()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        }\r\n        else {\r\n            window.location.href = editUrl + \'?addressId=\' + editId + \"&isUpdate=1&returnUrl=");
#nullable restore
#line 94 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                                                                                        Write(HttpUtility.UrlEncode(Context.Request.GetDisplayUrl()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        }\r\n    }\r\n\r\n    function EditAddr(addId) {\r\n        var isOrder = QueryString(\'isOrder\');\r\n        if (isOrder) {\r\n            window.location.href = editUrl + \'?addressId=\' + addId + \'&isOrder=\' + isOrder + \"&returnUrl=");
#nullable restore
#line 101 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                                                                                                    Write(HttpUtility.UrlEncode(Context.Request.GetDisplayUrl()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        }\r\n        else {\r\n            window.location.href = editUrl + \'?addressId=\' + addId + \"&returnUrl=");
#nullable restore
#line 104 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Areas\Mobile\Templates\Default\Views\Order\ChooseShippingAddress.cshtml"
                                                                            Write(HttpUtility.UrlEncode(Context.Request.GetDisplayUrl()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
        }
    }

    function DeleteAddr(item, addId) {
        $.dialog.confirm(""是否删除该地址？"", function (e) {
            var loading = showLoading();
            $.post(deleteUrl, { addressId: addId }, function (result) {
                if (result.success) {
                    loading.close();
                    $(item).closest('li').remove();
                    count = $('ul.address').children('li').length;
                    if (count == 0) {
                        window.saveToLocalStorage(cacheKey, { isClear: true });
                    }
                }
            });
        });
    }

    function saveAndGoBack(addId) {
        var sto = window.sessionStorage;
        var refer;
        refer = window.localStorage.getItem(""refer"");
        if (sto != null && sto != undefined && refer == null) {
            refer = window.sessionStorage.getItem(""refer"");
        }
        //if (refer == null) {
        //    window.location.href = location.href;
        //}
    ");
            WriteLiteral(@"    var li = $('#' + addId);
        var value = {
            id: addId,
            latAndLng: li.attr(""latAndLng""),
            shipTo: li.attr('shipTo'),
            phone: li.attr('phone'),
            regionFullName: li.attr('regionFullName'),
            address: li.attr('address'),
            regionId: li.attr('regionId'),
            addressDetail: li.attr('addressDetail')
        };
        window.saveToLocalStorage(cacheKey, value);
        if (refer != null && refer != '') {
            window.localStorage.removeItem(""refer"");
            if (sto != null && sto != undefined) {
                window.sessionStorage.removeItem(""refer"");
            }

            window.location.href = refer;
        } else {
            //获取URL中值
            //var returl = getQueryString(""returnUrl"");
            //if (returl && returl.length > 0) {
            //    window.location.href = returl;
            //}
            window.location.reload();
        }
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mall.Entities.ShippingAddressInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
