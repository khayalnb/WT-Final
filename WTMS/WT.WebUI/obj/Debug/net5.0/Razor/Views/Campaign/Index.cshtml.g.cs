#pragma checksum "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\Campaign\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e734aebc7b8cc2513e68a83accf85cdaf8ea869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Campaign_Index), @"mvc.1.0.view", @"/Views/Campaign/Index.cshtml")]
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
#line 1 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\_ViewImports.cshtml"
using WT.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\_ViewImports.cshtml"
using WT.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\_ViewImports.cshtml"
using WT.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\_ViewImports.cshtml"
using WT.WebUI.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\_ViewImports.cshtml"
using WT.BLL.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e734aebc7b8cc2513e68a83accf85cdaf8ea869", @"/Views/Campaign/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a00597076510193acdadde0f0c80ac191a647587", @"/Views/_ViewImports.cshtml")]
    public class Views_Campaign_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OfferCompany>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Campaign", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CampaignDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <link rel=""stylesheet"" href=""assets/css/company.css"">


    <section class=""my-3"">
        <div class=""container"">
            <div class=""row mb-3"">
                <div class=""-col-sm-12"">
                    <h3>Kampaniyalar</h3>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 13 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\Campaign\Index.cshtml"
                 if (Model is not null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\Campaign\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-sm-6 mb-3\">\r\n                            <div class=\"company-card d-flex\">\r\n                                <div class=\"card-image\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 694, "\"", 768, 2);
            WriteAttributeValue("", 700, "/AdminPanelProjectFolderNameImages/OfferCompanyImage/", 700, 53, true);
#nullable restore
#line 20 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\Campaign\Index.cshtml"
WriteAttributeValue("", 753, item.ImageName, 753, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 769, "\"", 775, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"company-info\">\r\n                                    <h5>");
#nullable restore
#line 23 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\Campaign\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 25 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\Campaign\Index.cshtml"
                                   Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>...</span>\r\n                                    </p>\r\n                                    <div class=\"more-info-and-date\">\r\n                                        <time>Tarix: 21 - 28 Fevral</time>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e734aebc7b8cc2513e68a83accf85cdaf8ea8696785", async() => {
                WriteLiteral("Daha ətraflı");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\Campaign\Index.cshtml"
                                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 34 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\Campaign\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebUI\Views\Campaign\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OfferCompany>> Html { get; private set; }
    }
}
#pragma warning restore 1591
