#pragma checksum "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Ajax\LoadMoreNewsPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d6e90b3f6385293ce1a792cf25e3652d2fedb08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ajax_LoadMoreNewsPartialView), @"mvc.1.0.view", @"/Views/Ajax/LoadMoreNewsPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ajax/LoadMoreNewsPartialView.cshtml", typeof(AspNetCore.Views_Ajax_LoadMoreNewsPartialView))]
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
#line 1 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#line 2 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d6e90b3f6385293ce1a792cf25e3652d2fedb08", @"/Views/Ajax/LoadMoreNewsPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Ajax_LoadMoreNewsPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit:cover!important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewsDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Ajax\LoadMoreNewsPartialView.cshtml"
 foreach (var news in Model)
{

#line default
#line hidden
            BeginContext(61, 213, true);
            WriteLiteral("    <div class=\"col-12 col-sm-12 col-md-12 col-lg-6\">\r\n        <div class=\"one-news d-flex\">\r\n            <div class=\"col-12 col-sm-12 col-md-6\">\r\n                <div class=\"one-news-image\">\r\n                    ");
            EndContext();
            BeginContext(274, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "790d12d856a848ec99c442315cdee87e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 319, "~/img/", 319, 6, true);
#line 9 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Ajax\LoadMoreNewsPartialView.cshtml"
AddHtmlAttributeValue("", 325, news.PhotoUrl, 325, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(341, 229, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-12 col-sm-12 col-md-6\">\r\n                <div class=\"one-news-title-about\">\r\n                    <div class=\"one-news-title\">\r\n                        <h5>");
            EndContext();
            BeginContext(571, 10, false);
#line 15 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Ajax\LoadMoreNewsPartialView.cshtml"
                       Write(news.Title);

#line default
#line hidden
            EndContext();
            BeginContext(581, 112, true);
            WriteLiteral("</h5>\r\n                    </div>\r\n                    <div class=\"one-news-about\">\r\n                        <p>");
            EndContext();
            BeginContext(694, 9, false);
#line 18 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Ajax\LoadMoreNewsPartialView.cshtml"
                      Write(news.Info);

#line default
#line hidden
            EndContext();
            BeginContext(703, 36, true);
            WriteLiteral("</p>\r\n                        <span>");
            EndContext();
            BeginContext(740, 37, false);
#line 19 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Ajax\LoadMoreNewsPartialView.cshtml"
                         Write(news.AddDate.Date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(777, 67, true);
            WriteLiteral("</span>\r\n                        <button class=\"one-news-more-btn\">");
            EndContext();
            BeginContext(844, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79222f2b3c4a4287b75cd8b0e3e36522", async() => {
                BeginContext(918, 7, true);
                WriteLiteral("Ətraflı");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Ajax\LoadMoreNewsPartialView.cshtml"
                                                                                                              WriteLiteral(news.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(929, 113, true);
            WriteLiteral("</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
            EndContext();
#line 27 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Ajax\LoadMoreNewsPartialView.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
