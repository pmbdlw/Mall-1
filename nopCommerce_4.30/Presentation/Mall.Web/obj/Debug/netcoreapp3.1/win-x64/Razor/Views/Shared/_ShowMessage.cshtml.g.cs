#pragma checksum "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\_ShowMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8738ec482b77ba88cab2421c15b6b64f4842ed7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ShowMessage), @"mvc.1.0.view", @"/Views/Shared/_ShowMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8738ec482b77ba88cab2421c15b6b64f4842ed7e", @"/Views/Shared/_ShowMessage.cshtml")]
    public class Views_Shared__ShowMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script>\r\n\t\t(function () {\r\n\t\t\tvar data= ");
#nullable restore
#line 3 "C:\S\nopCommerce_4.30_dev\Presentation\Mall.Web\Views\Shared\_ShowMessage.cshtml"
                  Write(Html.Raw(TempData["__Message__"]??"null"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
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
</script>");
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
