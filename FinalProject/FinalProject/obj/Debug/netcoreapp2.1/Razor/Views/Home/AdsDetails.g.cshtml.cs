#pragma checksum "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b578d7c01d255540d9891b7174360f4e30d05f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdsDetails), @"mvc.1.0.view", @"/Views/Home/AdsDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AdsDetails.cshtml", typeof(AspNetCore.Views_Home_AdsDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b578d7c01d255540d9891b7174360f4e30d05f", @"/Views/Home/AdsDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdsDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Announcement>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit:cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
  
    ViewData["Title"] = "AdsDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(115, 246, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    <section id=\"phoneDetails\">\r\n        <div class=\"container\">\r\n            <div class=\"row phone-details-row1\">\r\n                <div class=\"phone-zoom-img d-none\">\r\n                    <div class=\"phone-img\">\r\n                        ");
            EndContext();
            BeginContext(361, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f9e9ace39d8480593072960be677da8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(405, 365, true);
            WriteLiteral(@"
                        <div  class=""image-close"">
                            <i class=""fas fa-times""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-sm-12 col-md-12 col-lg-6"">
                    <div style=""height:548px;"" class=""phone-ads-main-image"">
                        ");
            EndContext();
            BeginContext(770, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "970b04f2d77049d7ada7e629f5b669a1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 798, "~/img/", 798, 6, true);
#line 23 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
AddHtmlAttributeValue("", 804, Model.PhotoUrl, 804, 15, false);

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
            BeginContext(821, 179, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-12 col-sm-12 col-md-12 col-lg-6\">\r\n                    <div class=\"row phone-details-row2\">\r\n");
            EndContext();
#line 28 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                         foreach (var img in Model.AnsImages)
                        {

#line default
#line hidden
            BeginContext(1090, 170, true);
            WriteLiteral("                            <div class=\"col-6\">\r\n                                <div style=\"height:320px;\" class=\"phone-ads-image\">\r\n                                    ");
            EndContext();
            BeginContext(1260, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cec9adcc77634b1d842287611113aef9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1288, "~/img/", 1288, 6, true);
#line 32 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
AddHtmlAttributeValue("", 1294, img.AdsPhotoUrl, 1294, 16, false);

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
            BeginContext(1312, 78, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 35 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                        }

#line default
#line hidden
            BeginContext(1417, 387, true);
            WriteLiteral(@"

                    </div>
                </div>

            </div>
            <div class=""row"">
                <div class=""col-12 order-1  col-sm-6 order-sm-1  col-md-6 col-lg-3 order-md-0"">
                    <div class=""ads-all-details"">
                        <div class=""ads-price d-flex justify-content-center align-items-center"">
                            <h5>");
            EndContext();
            BeginContext(1805, 11, false);
#line 46 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                           Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1816, 240, true);
            WriteLiteral("<small>AZN</small></h5>\r\n                        </div>\r\n                        <div class=\"ads-details-first\">\r\n                            <div class=\"ads-contact-info d-flex justify-content-around\">\r\n                                <h5>");
            EndContext();
            BeginContext(2057, 34, false);
#line 50 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                               Write(Model.User.Operator.OperatorNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2091, 1, true);
            WriteLiteral("-");
            EndContext();
            BeginContext(2093, 22, false);
#line 50 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                                                                   Write(Model.User.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2115, 201, true);
            WriteLiteral("</h5>\r\n                                <i class=\"fas fa-phone\"></i>\r\n                            </div>\r\n                            <div class=\"ads-contact-name\">\r\n                                <h5>");
            EndContext();
            BeginContext(2317, 20, false);
#line 54 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                               Write(Model.User.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(2337, 226, true);
            WriteLiteral("</h5>\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n                        <div class=\"ads-details-second d-flex flex-column align-items-center\">\r\n                            <h5>Elanın Baxış Sayı: ");
            EndContext();
            BeginContext(2564, 23, false);
#line 60 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                                              Write(Model.AnnouncementCount);

#line default
#line hidden
            EndContext();
            BeginContext(2587, 54, true);
            WriteLiteral("</h5>\r\n                            <h5>Yerləşdirilib: ");
            EndContext();
            BeginContext(2642, 38, false);
#line 61 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                                          Write(Model.AddDate.Date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2680, 331, true);
            WriteLiteral(@";</h5>
                        </div>
                    </div>

                </div>
                <div class=""col-12 order-0 order-sm-0  col-sm-6 col-md-6 col-lg-9 order-md-1"">
                    <div class=""ads-all-details-2"">
                        <div class=""ads-product-name"">
                            <h2>");
            EndContext();
            BeginContext(3012, 10, false);
#line 69 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3022, 345, true);
            WriteLiteral(@"</h2>
                        </div>
                        <div class=""ads-product-details"">
                            <table class=""table"">
                                <tbody>
                                    <tr>
                                        <td><span>Şəhər</span></td>
                                        <td>");
            EndContext();
            BeginContext(3368, 15, false);
#line 76 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                                       Write(Model.City.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3383, 205, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td><span>Marka</span></td>\r\n                                        <td>");
            EndContext();
            BeginContext(3589, 21, false);
#line 80 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                                       Write(Model.Model.Mark.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3610, 207, true);
            WriteLiteral("</td>\r\n\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <td><span>Model</span></td>\r\n                                        <td>");
            EndContext();
            BeginContext(3818, 16, false);
#line 85 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                                       Write(Model.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3834, 163, true);
            WriteLiteral("</td>\r\n\r\n                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                            <p>");
            EndContext();
            BeginContext(3998, 10, false);
#line 90 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Views\Home\AdsDetails.cshtml"
                          Write(Model.Info);

#line default
#line hidden
            EndContext();
            BeginContext(4008, 142, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Announcement> Html { get; private set; }
    }
}
#pragma warning restore 1591
