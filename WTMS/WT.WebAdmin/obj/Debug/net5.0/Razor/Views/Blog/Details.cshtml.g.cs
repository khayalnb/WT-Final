#pragma checksum "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62c56e66ad991b2c735c600e41c20781972d38d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c56e66ad991b2c735c600e41c20781972d38d0", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b678ea5dfc175ed7a4cdbf7efa8fbb07da25f5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("319"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    .btn-outline-secondary:hover #reset{
        fill:#ffffff;
    }
    .rounded {
        box-shadow: rgba(0, 0, 0, 0.02) 0px 1px 3px 0px, rgba(27, 31, 35, 0.15) 0px 0px 0px 1px;
        width:100%;
        height:319px;
    }
    .bg-label-primary {
        box-shadow: rgba(0, 0, 0, 0.02) 0px 1px 3px 0px, rgba(27, 31, 35, 0.15) 0px 0px 0px 1px;
        padding: 15px 112px;
    }
    .text-container {
        box-shadow: rgba(0, 0, 0, 0.02) 0px 1px 3px 0px, rgba(27, 31, 35, 0.15) 0px 0px 0px 1px;
        border-radius:5px;
        padding:1rem;
        margin:2rem 0px;
    }
</style>
<div class=""container-fluid flex-grow-1 container-p-y"">

    <div class=""card mb-4"">
        <div class=""d-flex justify-content-between align-items-center"">
            <h5 class=""card-header"">Detallar</h5>
           
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-sm-6"" style=""height:fit-content"">
                    <label clas");
            WriteLiteral("s=\"form-label\">Şəkil</label>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "62c56e66ad991b2c735c600e41c20781972d38d06869", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1100, "~/", 1100, 2, true);
#nullable restore
#line 33 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 1102, Model.ImageName, 1102, 16, false);

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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-sm-6\">\r\n                    <div class=\"row\" style=\"padding-top: 1.9rem !important;\">\r\n                        <div class=\"col-sm-12 mb-4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62c56e66ad991b2c735c600e41c20781972d38d08745", async() => {
                WriteLiteral(@"
                                <svg id=""reset"" xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""#8592a3"" class=""bi bi-arrow-clockwise"" viewBox=""0 0 16 16"">
                                    <path fill-rule=""evenodd"" d=""M8 3a5 5 0 1 0 4.546 2.914.5.5 0 0 1 .908-.417A6 6 0 1 1 8 2v1z"" />
                                    <path d=""M8 4.466V.534a.25.25 0 0 1 .41-.192l2.36 1.966c.12.1.12.284 0 .384L8.41 4.658A.25.25 0 0 1 8 4.466z"" />
                                </svg>
                                Səhifəni yenilə
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml"
                                                                                                              WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"mb-4 col-md-6\">\r\n                            <label for=\"organization\" class=\"form-label\">Status</label>\r\n");
#nullable restore
#line 48 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml"
                             if (Model.IsActive == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div><span class=\"badge bg-label-primary me-1\">Active</span></div> ");
#nullable restore
#line 49 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml"
                                                                                                }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div><span class=\"badge bg-label-warning me-1\">Deactive</span></div>");
#nullable restore
#line 51 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml"
                                                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""mb-4 col-md-6"">
                            <label for=""firstName"" class=""form-label"">Id</label>
                            <input class=""form-control"" type=""text"" id=""firstName"" disabled");
            BeginWriteAttribute("value", " value=\"", 2791, "\"", 2808, 1);
#nullable restore
#line 55 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml"
WriteAttributeValue("", 2799, Model.Id, 2799, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""mb-4 col-md-6"">
                            <label for=""lastName"" class=""form-label"">Başlıq</label>
                            <input class=""form-control"" type=""text"" name=""lastName"" disabled id=""lastName""");
            BeginWriteAttribute("value", " value=\"", 3088, "\"", 3108, 1);
#nullable restore
#line 59 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml"
WriteAttributeValue("", 3096, Model.Title, 3096, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""mb-4 col-md-6"">
                            <label for=""email"" class=""form-label"">Yaradıldığı tarix</label>
                            <input class=""form-control"" type=""text"" id=""email"" name=""email"" disabled");
            BeginWriteAttribute("value", " value=\"", 3390, "\"", 3417, 1);
#nullable restore
#line 63 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml"
WriteAttributeValue("", 3398, Model.Created_Date, 3398, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""mb-4 col-md-6"">
                            <label for=""organization"" class=""form-label"">Dəyişiklik olunduğu tarix</label>
                            <input type=""text"" class=""form-control"" id=""organization"" disabled");
            BeginWriteAttribute("value", " value=\"", 3708, "\"", 3791, 1);
#nullable restore
#line 67 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml"
WriteAttributeValue("", 3716, Model.Updated_Date == null ? "Dəyişiklik edilməyib" : Model.Updated_Date, 3716, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""mb-4 col-md-6"">
                            <label for=""organization"" class=""form-label"">Silindiyi tarix</label>
                            <input type=""text"" class=""form-control"" id=""organization"" disabled");
            BeginWriteAttribute("value", " value=\"", 4072, "\"", 4153, 1);
#nullable restore
#line 71 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml"
WriteAttributeValue("", 4080, Model.Deleted_Date == null ? "Məlumat silinməyib" : Model.Deleted_Date, 4080, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-12\">\r\n                    <div class=\"text-container\">\r\n                        <p disabled >");
#nullable restore
#line 77 "C:\Users\Siyaset\Desktop\wt\WTMS\WT.WebAdmin\Views\Blog\Details.cshtml"
                                Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""mt-2 col-sm-12"">
                    <button type=""submit"" class=""btn btn-primary me-2"">Save changes</button>
                    <button type=""reset"" class=""btn btn-outline-secondary"">Cancel</button>
                </div>
            </div>
               
        </div>
        <!-- /Account -->
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
