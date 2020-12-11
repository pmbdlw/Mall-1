#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\_SelectMenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ea7af2e8c7224e7d4f9b4d644afc9b511a980fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SelectMenuItem), @"mvc.1.0.view", @"/Views/Shared/_SelectMenuItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea7af2e8c7224e7d4f9b4d644afc9b511a980fc", @"/Views/Shared/_SelectMenuItem.cshtml")]
    public class Views_Shared__SelectMenuItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
    //选择菜单
    var localStorageKey = ""SelectmenuItem-LocalStorageKey"";
    if (window.localStorage) {
        $(document).on('click', '.nav.navbar-nav .dropdown-menu a,.aside .aside-list a', function (e) {
            window.localStorage.setItem(localStorageKey, $(e.target).attr('href'));
        });
    }

    var url = location.href;

    var headimgurl = QueryString('displayUrl');
    if (headimgurl)
        url = headimgurl;

    var dropdownMenu = findMenuItem(url);
    if (dropdownMenu == null && window.localStorage) {
        var value = window.localStorage.getItem(localStorageKey);
        if (value)
            dropdownMenu = findMenuItem(value);
    }
    else {
        window.localStorage.setItem(localStorageKey, location.pathname);
    }
    if (dropdownMenu) {
        $('ul.aside-list').append(dropdownMenu.children('li').clone());
    }
    rendStyle();
    function findMenuItem(url) {
        var dropdownMenu;
        $('.nav.navbar-nav .dropdown-menu a').e");
            WriteLiteral(@"ach(function () {
            if (dropdownMenu)
                return;
            var a = $(this);
            var href = a.attr('href');
            if (url.indexOf(""?"") < 0) {
                href = href.split(""?"")[0];
            }
            var index = url.toLowerCase().indexOf(href.toLowerCase());
            if (url.toLowerCase() == href.toLowerCase() || index >= 0 && index + href.length == url.length) {//判断地址栏的地址是否以a的href结尾
                var dm = a.closest('.dropdown-menu');
                if (dm.length > 0) {
                    var li = dm.closest('li');
                    if (li.length > 0) {
                        li.addClass('active');
                        a.closest('li').addClass('current');
                        dropdownMenu = dm;
                    }
                }
            }
        });

        return dropdownMenu;
    }
    function rendStyle() {
        var OrderId = GetQueryString('orderid');
        var showtype = $(""#Showty"").val();
       ");
            WriteLiteral(" if (Number(OrderId) > 0 && Number(showtype) > 0) {\r\n            var _id = showtype == 2 ? 3002 : 3003;\r\n            $(\'ul.aside-list\').find(\"#\" + _id).parent().addClass(\"current\").siblings().removeClass(\"current\");\r\n        }\r\n    }\r\n</script>");
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
