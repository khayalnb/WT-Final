#pragma checksum "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae476854e214287aeb0c49ceb674ed4f70d0648e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\_ViewImports.cshtml"
using WT.WebAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\_ViewImports.cshtml"
using WT.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\_ViewImports.cshtml"
using WT.WebAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\_ViewImports.cshtml"
using WT.DAL.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\_ViewImports.cshtml"
using WT.WebAdmin.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\_ViewImports.cshtml"
using WT.WebAdmin.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\_ViewImports.cshtml"
using WT.DAL.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae476854e214287aeb0c49ceb674ed4f70d0648e", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b678ea5dfc175ed7a4cdbf7efa8fbb07da25f5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mx-auto d-block rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mx-auto d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/img/illustrations/page-misc-error-light.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("page-misc-error-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-app-dark-img", new global::Microsoft.AspNetCore.Html.HtmlString("illustrations/page-misc-error-dark.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-app-light-img", new global::Microsoft.AspNetCore.Html.HtmlString("illustrations/page-misc-error-light.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .active {
        box-shadow: rgba(0, 0, 0, 0.02) 0px 1px 3px 0px, rgba(27, 31, 35, 0.15) 0px 0px 0px 1px !important;
        background-color: white !important;
    }
    .nav-link {
        padding: 0.5rem 0.25rem !important;
    }
</style>

<div class=""container-fluid flex-grow-1 container-p-y"">
");
#nullable restore
#line 15 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-12"">

                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-xl-6"">
                                <div class=""product-detai-imgs"">
                                    <div class=""row"">
                                        <div class=""col-md-2 col-sm-3 col-4"">
                                            <div class=""nav flex-column nav-pills "" id=""v-pills-tab"" role=""tablist"" aria-orientation=""vertical"">
");
#nullable restore
#line 28 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                  
                                                    int count = 0;
                                                    foreach (var item in Model.Images)
                                                    {
                                                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <a");
            BeginWriteAttribute("class", " class=\"", 1406, "\"", 1450, 2);
            WriteAttributeValue("", 1414, "nav-link", 1414, 8, true);
#nullable restore
#line 33 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
WriteAttributeValue(" ", 1422, count==1 ? "active" : "", 1423, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1451, "\"", 1474, 3);
            WriteAttributeValue("", 1456, "product-", 1456, 8, true);
#nullable restore
#line 33 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
WriteAttributeValue("", 1464, count, 1464, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1470, "-tab", 1470, 4, true);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"pill\"");
            BeginWriteAttribute("href", " href=\"", 1497, "\"", 1519, 2);
            WriteAttributeValue("", 1504, "#product-", 1504, 9, true);
#nullable restore
#line 33 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
WriteAttributeValue("", 1513, count, 1513, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1531, "\"", 1561, 2);
            WriteAttributeValue("", 1547, "product-", 1547, 8, true);
#nullable restore
#line 33 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
WriteAttributeValue("", 1555, count, 1555, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-selected=\"true\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ae476854e214287aeb0c49ceb674ed4f70d0648e12029", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1656, "~/Documents/ProductImage/", 1656, 25, true);
#nullable restore
#line 34 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 1681, item.ImageName, 1681, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </a>\r\n");
#nullable restore
#line 36 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                        <div class=""col-md-7 offset-md-1 col-sm-9 col-8"">
                                            <div class=""tab-content"" id=""v-pills-tabContent"" style=""padding:0; "">
");
#nullable restore
#line 42 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                  
                                                    int count1 = 0;
                                                    foreach (var item in Model.Images)
                                                    {
                                                        count1++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div");
            BeginWriteAttribute("class", " class=\"", 2614, "\"", 2669, 3);
            WriteAttributeValue("", 2622, "tab-pane", 2622, 8, true);
            WriteAttributeValue(" ", 2630, "fade", 2631, 5, true);
#nullable restore
#line 47 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
WriteAttributeValue(" ", 2635, count1==1 ? "show active" : "", 2636, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2670, "\"", 2690, 2);
            WriteAttributeValue("", 2675, "product-", 2675, 8, true);
#nullable restore
#line 47 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
WriteAttributeValue("", 2683, count1, 2683, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2707, "\"", 2744, 3);
            WriteAttributeValue("", 2725, "product-", 2725, 8, true);
#nullable restore
#line 47 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
WriteAttributeValue("", 2733, count1, 2733, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2740, "-tab", 2740, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <div>\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ae476854e214287aeb0c49ceb674ed4f70d0648e16510", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2889, "~/Documents/ProductImage/", 2889, 25, true);
#nullable restore
#line 49 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 2914, item.ImageName, 2914, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            </div>\r\n                                                        </div>\r\n");
#nullable restore
#line 52 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class=""col-xl-6"">
                                <div class=""mt-4 mt-xl-3"">
                                    <h6 class=""text-black"">Kateqoriya: <span class=""text-muted"">");
#nullable restore
#line 62 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                           Write(Model.SubCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </h6>\r\n                                    <h6 class=\"text-black\">Brand: <span class=\"text-muted\">");
#nullable restore
#line 63 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                      Write(Model.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                                    <h6 class=\"text-black\">Model: <span class=\"text-muted\">");
#nullable restore
#line 64 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                                    <h6 class=\"text-black\">Endirim faizi: <span class=\"text-muted\">");
#nullable restore
#line 65 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                              Write(ViewBag.percent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span></h6>\r\n                                    <h6 class=\"text-black\">Qiymət: <span class=\"text-muted\">");
#nullable restore
#line 66 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</span></h6>\r\n                                    <h6 class=\"text-black\">Nağd alış qiyməti: <span class=\"text-muted\"><del>");
#nullable restore
#line 67 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</del></span>  <span class=\"text-muted ms-2\">");
#nullable restore
#line 67 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                                                                                                     Write(Model.Price-@Model.DisCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</span></h6>\r\n                                    <h6 class=\"text-black\">Məhsulun sayı: <span class=\"text-muted\">");
#nullable restore
#line 68 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                              Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                                    <h6 class=\"text-black\">Qaranti müddəti: <span class=\"text-muted\">");
#nullable restore
#line 69 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                                Write(Model.WarrantyYearNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" il</span></h6>\r\n                                    <h6 class=\"text-black\">Kamaniya: <span class=\"text-muted\">");
#nullable restore
#line 70 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                         Write(Model.OfferCompany.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                                    <h6 class=\"text-black\">Çatdırılma: <span class=\"text-muted\">");
#nullable restore
#line 71 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                           Write(Model.IsFreeDelivery);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h6>
                                </div>
                            </div>
                        </div>
                        <!-- end row -->

                        <div class=""mt-5"">
                            <h5 class=""mb-3"">Xüsusiyyətlər :</h5>
                            <div class=""row"">
");
#nullable restore
#line 80 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                 if (ViewBag.Specifications is not null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                     foreach (string item in ViewBag?.Specifications)
                                    {
                                        if (!string.IsNullOrWhiteSpace(item))
                                        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"col-sm-6  mb-1\">\r\n                                                <p class=\"text-black border border-success p-2 rounded\">");
#nullable restore
#line 87 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                                                                                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n");
#nullable restore
#line 89 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                        }

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 99 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"misc-wrapper\" style=\"margin: 0 auto; width: fit-content; text-align: center;\">\r\n            <h2 class=\"mb-2 mx-2\">Məlumat tapilmadi :(</h2>\r\n            <p class=\"mb-4 mx-2\">Oops! 😖</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae476854e214287aeb0c49ceb674ed4f70d0648e26309", async() => {
                WriteLiteral("Geri qayıt");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"mt-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ae476854e214287aeb0c49ceb674ed4f70d0648e27604", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 111 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Product\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
