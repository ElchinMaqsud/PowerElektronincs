#pragma checksum "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fd3b7daaf6911d114878fead9e9d59c9c783523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PowerAdmin_Views_Dashboard_AdsDetails), @"mvc.1.0.view", @"/Areas/PowerAdmin/Views/Dashboard/AdsDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/PowerAdmin/Views/Dashboard/AdsDetails.cshtml", typeof(AspNetCore.Areas_PowerAdmin_Views_Dashboard_AdsDetails))]
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
#line 1 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#line 2 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fd3b7daaf6911d114878fead9e9d59c9c783523", @"/Areas/PowerAdmin/Views/Dashboard/AdsDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/PowerAdmin/Views/_ViewImports.cshtml")]
    public class Areas_PowerAdmin_Views_Dashboard_AdsDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Announcement>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px;height:200px;object-fit:cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "PowerAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmAnnouncement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteWrongAds", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmedAnnouncements", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DontConfirmedAnnouncements", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
  
    ViewData["Title"] = "AdsDetails";
    Layout = "~/Areas/PowerAdmin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(136, 465, true);
            WriteLiteral(@"
<section id=""phoneDetails"">
    <div class=""container"">
        <div class=""row phone-details-row1"">
            <table class=""table table-hover table-dark"">
                <thead>
                    <tr>
                        <th scope=""col"">Əsas Şəkil</th>
                        <th scope=""col"">Əlavə Şəkillər</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
            EndContext();
            BeginContext(601, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4bb3f5880cb0463c87344aea8d9e365f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 611, "~/img/", 611, 6, true);
#line 19 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
AddHtmlAttributeValue("", 617, Model.PhotoUrl, 617, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(686, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 20 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                         foreach (var img in Model.AnsImages)
                        {

#line default
#line hidden
            BeginContext(783, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(815, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d73fad38afb541789a4a249c939d4a75", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 825, "~/img/", 825, 6, true);
#line 22 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
AddHtmlAttributeValue("", 831, img.AdsPhotoUrl, 831, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(901, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 23 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                        }

#line default
#line hidden
            BeginContext(935, 892, true);
            WriteLiteral(@"                    </tr>

                </tbody>
            </table>
        </div>
        <div class=""row"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th scope=""col"">Başlıq</th>
                        <th scope=""col"">Kateqoriya</th>
                        <th scope=""col"">Marka</th>
                        <th scope=""col"">Model</th>
                        <th scope=""col"">Haqqında</th>
                        <th scope=""col"">Qiyməti</th>
                        <th scope=""col"">Şəhər</th>
                        <th scope=""col"">Adı</th>
                        <th scope=""col"">Operator Nömrəsi</th>
                        <th scope=""col"">Nömrəsi</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
            EndContext();
            BeginContext(1828, 10, false);
#line 47 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1838, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1874, 30, false);
#line 48 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                       Write(Model.Model.Mark.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1904, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1940, 21, false);
#line 49 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                       Write(Model.Model.Mark.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1961, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1997, 16, false);
#line 50 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                       Write(Model.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2013, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2049, 10, false);
#line 51 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                       Write(Model.Info);

#line default
#line hidden
            EndContext();
            BeginContext(2059, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2095, 11, false);
#line 52 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                       Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2106, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2142, 15, false);
#line 53 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                       Write(Model.City.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2157, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2193, 10, false);
#line 54 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2203, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2239, 34, false);
#line 55 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                       Write(Model.User.Operator.OperatorNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2273, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2309, 22, false);
#line 56 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                       Write(Model.User.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2331, 102, true);
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n");
            EndContext();
#line 63 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
         if (Model.IsConfirmed == false)
        {

#line default
#line hidden
            BeginContext(2486, 411, true);
            WriteLiteral(@"            <div class=""row"">

                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">Təsdiqlə</th>
                            <th scope=""col"">Xeyr</th>
                        </tr>

                    </thead>
                    <tbody>
                        <tr>
                            <td>");
            EndContext();
            BeginContext(2897, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e36f2b54f1f7446eb4fab3d02e063a95", async() => {
                BeginContext(3053, 71, true);
                WriteLiteral("<i style=\"color:white;font-size:22px;\" class=\"far fa-check-circle\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                                                                                                                                                                     WriteLiteral(Model.Id);

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
            BeginContext(3128, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3167, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69f5c00b24304b74b79a5b570caa99d2", async() => {
                BeginContext(3317, 71, true);
                WriteLiteral("<i style=\"color:white;font-size:22px;\" class=\"far fa-times-circle\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
                                                                                                                                                               WriteLiteral(Model.Id);

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
            BeginContext(3392, 114, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n");
            EndContext();
#line 83 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
        }

#line default
#line hidden
            BeginContext(3517, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 84 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
         if (Model.IsConfirmed == true)
        {

#line default
#line hidden
            BeginContext(3569, 34, true);
            WriteLiteral("    <div class=\"col-12\">\r\n        ");
            EndContext();
            BeginContext(3603, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37311eb28dda4eed9cdba3ddc07ef50b", async() => {
                BeginContext(3737, 71, true);
                WriteLiteral("<i style=\"color:white;\" class=\"far fa-arrow-alt-circle-left\"></i>Geriyə");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3812, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 89 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(3862, 34, true);
            WriteLiteral("    <div class=\"col-12\">\r\n        ");
            EndContext();
            BeginContext(3896, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e6a2c11462f4a1cbb1579911caa0900", async() => {
                BeginContext(4034, 71, true);
                WriteLiteral("<i style=\"color:white;\" class=\"far fa-arrow-alt-circle-left\"></i>Geriyə");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4109, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 95 "C:\Users\code\Desktop\Final Project Deploy Son deyisikler - Copy - Copy\FinalProject\FinalProject\Areas\PowerAdmin\Views\Dashboard\AdsDetails.cshtml"

        }

#line default
#line hidden
            BeginContext(4136, 32, true);
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</section>\r\n\r\n");
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
