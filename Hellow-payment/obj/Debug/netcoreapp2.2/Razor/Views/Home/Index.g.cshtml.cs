#pragma checksum "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "981e78b1e6ef3d20855ea55c78c83dd965f40200"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\_ViewImports.cshtml"
using Hellow_payment;

#line default
#line hidden
#line 2 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\_ViewImports.cshtml"
using Hellow_payment.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"981e78b1e6ef3d20855ea55c78c83dd965f40200", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"951b32fa8a695c9cbe3c80f665b0839e524553d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hellow_payment.Models.BookPurchaseVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Purchase";

#line default
#line hidden
            BeginContext(101, 71, true);
            WriteLiteral("\r\n<div class=\"wrapper\">\r\n    <div class=\"checkout container\">\r\n        ");
            EndContext();
            BeginContext(172, 1097, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "981e78b1e6ef3d20855ea55c78c83dd965f402005068", async() => {
                BeginContext(252, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(267, 25, false);
#line 15 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml"
       Write(Html.HiddenFor(n => n.Id));

#line default
#line hidden
                EndContext();
                BeginContext(292, 130, true);
                WriteLiteral("\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\" name=\"Title\"");
                EndContext();
                BeginWriteAttribute("asp-for", " asp-for=\"", 422, "\"", 444, 1);
#line 18 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml"
WriteAttributeValue("", 432, Model.Title, 432, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(445, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(447, 11, false);
#line 18 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml"
                                                                          Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(458, 48, true);
                WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
                EndContext();
                BeginContext(507, 17, false);
#line 19 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(524, 81, true);
                WriteLiteral("</p>\r\n                    <p class=\"card-text\"><small class=\"text-muted\">Author: ");
                EndContext();
                BeginContext(606, 12, false);
#line 20 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml"
                                                                      Write(Model.Author);

#line default
#line hidden
                EndContext();
                BeginContext(618, 88, true);
                WriteLiteral("</small></p>\r\n                    <p class=\"card-text\"><small class=\"text-muted\">Price: ");
                EndContext();
                BeginContext(707, 11, false);
#line 21 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml"
                                                                     Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(718, 101, true);
                WriteLiteral("</small></p>\r\n                </div>\r\n                <img style=\"width: 90%\" class=\"card-img-bottom\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 819, "\"", 841, 1);
#line 23 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml"
WriteAttributeValue("", 825, Model.Thumbnail, 825, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(842, 225, true);
                WriteLiteral(" alt=\"Card image cap\">\r\n            </div>\r\n            <section>\r\n                <div class=\"bt-drop-in-wrapper\">\r\n                    <div id=\"bt-dropin\"></div>\r\n                </div>\r\n            </section>\r\n            ");
                EndContext();
                BeginContext(1068, 51, false);
#line 30 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml"
       Write(Html.HiddenFor(n => n.Nonce, new { @id = "nonce" }));

#line default
#line hidden
                EndContext();
                BeginContext(1119, 105, true);
                WriteLiteral("\r\n            <hr />\r\n            <button class=\"btn btn-success\" type=\"submit\"><span>Confirm payment - $");
                EndContext();
                BeginContext(1225, 11, false);
#line 32 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml"
                                                                              Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(1236, 26, true);
                WriteLiteral("</span></button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1269, 150, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<script src=\"https://js.braintreegateway.com/web/dropin/1.22.0/js/dropin.min.js\"></script>\r\n<script>\r\n    var client_token = \"");
            EndContext();
            BeginContext(1420, 19, false);
#line 39 "C:\Users\hp\Desktop\HW-3\Hellow-payment\Hellow-payment\Views\Home\Index.cshtml"
                   Write(ViewBag.ClientToken);

#line default
#line hidden
            EndContext();
            BeginContext(1439, 619, true);
            WriteLiteral(@""";
    var form = document.querySelector('#payment-form');

    braintree.dropin.create({
        authorization: client_token,
        container: '#bt-dropin'
    }, function (createErr, instance) {
        form.addEventListener('submit', function (event) {
            event.preventDefault();

            instance.requestPaymentMethod(function (err, payload) {
                if (err) {
                    return;
                }
              
                document.querySelector('#nonce').value = payload.nonce;
                form.submit();
            });
        });
    });
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hellow_payment.Models.BookPurchaseVM> Html { get; private set; }
    }
}
#pragma warning restore 1591