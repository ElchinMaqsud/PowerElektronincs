#pragma checksum "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Shared\_AnnouncementLaptopPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ba1ef47344c13437b5bfe9135af3b481ef438f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AnnouncementLaptopPartialView), @"mvc.1.0.view", @"/Views/Shared/_AnnouncementLaptopPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AnnouncementLaptopPartialView.cshtml", typeof(AspNetCore.Views_Shared__AnnouncementLaptopPartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ba1ef47344c13437b5bfe9135af3b481ef438f", @"/Views/Shared/_AnnouncementLaptopPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AnnouncementLaptopPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Announcement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("about-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdsDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Shared\_AnnouncementLaptopPartialView.cshtml"
 foreach (var adsNotebook in Model)
{

#line default
#line hidden
            BeginContext(78, 178, true);
            WriteLiteral("    <div class=\"col-12 col-sm-12 col-md-6 col-lg-4\" data-aos=\"flip-up\" data-aos-duration=\"3000\">\r\n        <div class=\"comp\">\r\n            <div class=\"comp-img\">\r\n                ");
            EndContext();
            BeginContext(256, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dec2b56c9a6e4e70b54e7a1a1dd9cedc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 284, "~/img/", 284, 6, true);
#line 9 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Shared\_AnnouncementLaptopPartialView.cshtml"
AddHtmlAttributeValue("", 290, adsNotebook.PhotoUrl, 290, 21, false);

#line default
#line hidden
            AddHtmlAttributeValue("  ", 311, "", 313, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(317, 112, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"comp-name d-flex justify-content-between\">\r\n                <h5>");
            EndContext();
            BeginContext(430, 16, false);
#line 13 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Shared\_AnnouncementLaptopPartialView.cshtml"
               Write(adsNotebook.Name);

#line default
#line hidden
            EndContext();
            BeginContext(446, 94, true);
            WriteLiteral("</h5>\r\n                <div class=\"comp-activity\">\r\n                    \r\n                    ");
            EndContext();
            BeginContext(540, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5502e194f34944ef97625e6afb228dfd", async() => {
                BeginContext(639, 55, true);
                WriteLiteral("\r\n                        Ətraflı\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Shared\_AnnouncementLaptopPartialView.cshtml"
                                                                                          WriteLiteral(adsNotebook.Id);

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
            BeginContext(698, 209, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"comp-infos d-flex align-items-center justify-content-between\">\r\n                <div class=\"comp-info d-flex\">\r\n                    <small>");
            EndContext();
            BeginContext(908, 21, false);
#line 23 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Shared\_AnnouncementLaptopPartialView.cshtml"
                      Write(adsNotebook.City.Name);

#line default
#line hidden
            EndContext();
            BeginContext(929, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(932, 44, false);
#line 23 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Shared\_AnnouncementLaptopPartialView.cshtml"
                                              Write(adsNotebook.AddDate.Date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(976, 124, true);
            WriteLiteral("</small>\r\n                    \r\n                </div>\r\n                <div class=\"comp-price\">\r\n                    <span>");
            EndContext();
            BeginContext(1101, 17, false);
#line 27 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Shared\_AnnouncementLaptopPartialView.cshtml"
                     Write(adsNotebook.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1118, 85, true);
            WriteLiteral(" Azn</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 32 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Shared\_AnnouncementLaptopPartialView.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
