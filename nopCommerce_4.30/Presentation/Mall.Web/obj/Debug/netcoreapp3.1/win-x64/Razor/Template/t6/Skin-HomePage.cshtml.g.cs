#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Template\t6\Skin-HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ff1780cc28a883afbfedbf9a8f276bdf0209d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Template_t6_Skin_HomePage), @"mvc.1.0.view", @"/Template/t6/Skin-HomePage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ff1780cc28a883afbfedbf9a8f276bdf0209d4", @"/Template/t6/Skin-HomePage.cshtml")]
    public class Template_t6_Skin_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ff1780cc28a883afbfedbf9a8f276bdf0209d42744", async() => {
                WriteLiteral(@"
	<meta charset=""utf-8"">
	<meta name=""apple-mobile-web-app-capable"" content=""yes"">
	<meta name=""apple-mobile-web-app-status-bar-style"" content=""black-translucent"">
	<meta name=""apple-touch-fullscreen"" content=""yes"">
	<meta name=""format-detection"" content=""telephone=no, address=no"">
	<meta name=""viewport"" content=""width=device-width,initial-scale=1,maximum-scale=1,user-scalable=no"">
	<title>Mall首页</title>
	<script>
		(function() {
			var baseFontSize = 100;
			var baseWidth = 320;
			var clientWidth = document.documentElement.clientWidth || window.innerWidth;
			var innerWidth = Math.max(Math.min(clientWidth, 480), 320);

			var rem = 100;

			if (innerWidth > 362 && innerWidth <= 375) {
				rem = Math.floor(innerWidth / baseWidth * baseFontSize);
				//rem = Math.floor(innerWidth / baseWidth * baseFontSize * 0.9);
			}

			if (innerWidth > 375) {
				rem = Math.floor(innerWidth / baseWidth * baseFontSize);
				//rem = Math.floor(innerWidth / baseWidth * baseFontSize * 0.84);
			}

	");
                WriteLiteral(@"		window.__baseREM = rem;
			document.querySelector('html').style.fontSize = rem + 'px';
		}());
	</script>
	<link rel=""stylesheet"" href=""/Content/bootstrap.min.css"">
	<link rel=""stylesheet"" href=""/Areas/Mobile/Templates/Default/Content/custom.css"">
	
	<script src=""/Scripts/jquery-1.7.1.min.js""></script>
	<script src=""/Scripts/CommonJS.js""></script>
	<script src=""/Areas/Mobile/Templates/Default/Scripts/custom.js""></script>
	<script src=""/Areas/Mobile/Templates/Default/Scripts/buylib.js""></script>
	<script src=""/Scripts/imitateRequire.js""></script>
	<script>
		imitateRequireJS.addJsFile([{
			group: 'common',
			fileNames: [
				{ nickName: 'jquery.artDialog', fileName: 'jquery.artDialog.js' },
				{ nickName: 'artDialog', fileName: 'artDialog.iframeTools.js', depends: ['jquery.artDialog'] },
			]
		}]);
	</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ff1780cc28a883afbfedbf9a8f276bdf0209d45654", async() => {
                WriteLiteral("\r\n\t<!--_Base start-->\r\n\t<script>\r\n\t\tvar areaName = \'m-wap\';\r\n\t\tvar MAppType = \'0\';\r\n\t</script>\r\n\t\r\n\r\n<div class=\"container\">\r\n<!--_SearchBox start-->\r\n<header>\r\n    <div class=\"search search-bor-none\">\r\n        <input id=\"searchBox\" type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 2161, "\"", 2168, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2169, "\"", 2177, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""搜索全部商品..."" />
        <i class=""glyphicon glyphicon-search"" id=""searchBtn""></i>
    </div>
</header>
<script src=""/Areas/Mobile/Templates/Default/Scripts/searchBox.js""></script>
<!--_SearchBox end-->

<script src=""https://res.wx.qq.com/open/js/jweixin-1.0.0.js""></script>
<script src=""/Areas/Mobile/Templates/Default/Scripts/WeiXinShare.js""></script>
<script src=""/Areas/Mobile/Templates/Default/Scripts/IndexShare.js""></script>
<link rel=""stylesheet"" href=""/Content/PublicMob/css/style.css"" />
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/css.css"" rev=""stylesheet"" type=""text/css"">
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/mycss.css"" rev=""stylesheet"" type=""text/css"">
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/main.css"" rev=""stylesheet"" type=""text/css"">
<link rel=""stylesheet"" href=""/Areas/Admin/templates/common/style/head.css"">
        <div class=""members_con"" style=""margin:10px auto"">            
            <section clas");
                WriteLiteral("s=\"members_flash j-swipe\" id=\"mySwipe\">\r\n                <ul class=\"clearfix\">\r\n                            <li>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 3350, "\"", 3357, 0);
                EndWriteAttribute();
                WriteLiteral(@" title="" "">
                                    <img src=""http://zesion-test.img-cn-qingdao.aliyuncs.com/Storage/template/0/20160512/6359865967498374901974913.png"" width=""100%"" />
                                </a>
                            </li>
                        
                            <li>
                                <a href=""/m-wap/vshop/CouponInfo/22"" title=""测试的新优惠券"">
                                    
                                    
                                    <img src=""/temp/image/20170204/6362182358480666529128886.jpg"" width=""100%"" />
                                    
                                    
                                </a>
                            </li>
                        
                            <li>
                                <a");
                BeginWriteAttribute("href", " href=\"", 4194, "\"", 4201, 0);
                EndWriteAttribute();
                WriteLiteral(@" title="" "">
                                    
                                    
                                    <img src=""/temp/image/20170204/6362182146678577613262396.jpg"" width=""100%"" />
                                    
                                    
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
                            'width':'100%'
    ");
                WriteLiteral(@"                    })
                        $('body').css({
                            'height':'100%',
                            'width':'100%',
                            'background':'url(undefined) no-repeat',
                            'backgroundSize':'cover'
                        })
                    })
                </script><!--_4ButtonsFoot start111-->
<div class=""footerempty""></div>
<footer class=""clearfix"">
    <div class=""current"">
        <a href=""/m-wap/"">
            <i class=""home""></i>
            <p>首页1</p>
        </a>
    </div>
    <div");
                BeginWriteAttribute("class", " class=\"", 5821, "\"", 5829, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        <a href=\"/m-wap/VShop\">\r\n            <i class=\"vshop\"></i>\r\n            <p>微店1</p>\r\n        </a>\r\n    </div>\r\n    <div");
                BeginWriteAttribute("class", " class=\"", 5959, "\"", 5967, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        <a href=\"/m-wap/Category\">\r\n            <i class=\"classify\"></i>\r\n            <p>分类</p>\r\n        </a>\r\n    </div>\r\n\t<div");
                BeginWriteAttribute("class", " class=\"", 6099, "\"", 6107, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        <a href=\"/m-wap/Cart/Cart\">\r\n            <i class=\"f-cart\"></i>\r\n            <p>购物车</p>\r\n            <span class=\"plus-one\">1</span>\r\n        </a>\r\n    </div>\r\n    <div");
                BeginWriteAttribute("class", " class=\"", 6287, "\"", 6295, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        <a href=""/m-wap/Member/Center"">
            <i class=""user""></i>
            <p>个人中心</p>
        </a>
    </div>
</footer>
<!--_4ButtonsFoot end-->
</div>
<a class=""WX-backtop""></a>
<script src=""/Areas/Mobile/Templates/Default/Scripts/home.js""></script>
 <script src=""/Scripts/swipe-template.js""></script>

<script src=""/Areas/Mobile/Templates/Default/Scripts/_Aside.js""></script>
<div id=""customServices""></div>
	<div class=""wx_aside"">
            <!-- 返回顶部 -->
			<a href=""javascript:;"" class=""btn_top""></a>
	</div>
<!--_Aside end-->

	<script src=""/Scripts/jquery.nicescroll.min.js""></script>
	<script src=""/Areas/Mobile/Templates/Default/Scripts/_Base.js""></script>
	<link rel=""stylesheet"" href=""/Areas/Mobile/Templates/Default/Content/artdialog.css"">
	<script src=""/Scripts/jquery.artDialog.js""></script>
	<script src=""/Scripts/artDialog.iframeTools.js""></script>
	<script src=""/Scripts/jquery.cookie.js""></script>
	<script src=""/Scripts/jquery.scrollLoading.min.js""></script>
		<s");
                WriteLiteral(@"cript>
		(function () {
			var data= null;
			if (data) {
				var callback;
				if (data.goBack == true)
					callback = function () { history.go(-1); };
				var fun;
				if (data.type == -1)
					fun='errorTips';
				else if(data.type==0)
					fun='alert';
				else if (data.type == 1)
					fun='alertTips';
				else if (data.type == 2)
					fun='succeedTips';
				if(fun)
					$.dialog[fun](data.message,callback,data.time);
			}
		})();
</script>
	<!--_Base end-->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
