#pragma checksum "/home/soufiane/Bureau/works/Projects/coreProject/Views/etudiant/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "832dfa24445371572fcdc73894e697c3fbc48529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_etudiant_Details), @"mvc.1.0.view", @"/Views/etudiant/Details.cshtml")]
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
#line 1 "/home/soufiane/Bureau/works/Projects/coreProject/Views/_ViewImports.cshtml"
using coreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/soufiane/Bureau/works/Projects/coreProject/Views/_ViewImports.cshtml"
using coreProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"832dfa24445371572fcdc73894e697c3fbc48529", @"/Views/etudiant/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71afad4facc768cb88811d185ec529a25e6aa0a0", @"/Views/_ViewImports.cshtml")]
    public class Views_etudiant_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<coreProject.Models.Etudiant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "832dfa24445371572fcdc73894e697c3fbc485293938", async() => {
                WriteLiteral("\n    <div>\n         <label>codeCart</label>\n         <label>");
#nullable restore
#line 5 "/home/soufiane/Bureau/works/Projects/coreProject/Views/etudiant/Details.cshtml"
           Write(Html.DisplayFor(model => model.codeCart));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n    </div>\n    <div>\n         <label>nomEtudiant</label>\n         <label>");
#nullable restore
#line 9 "/home/soufiane/Bureau/works/Projects/coreProject/Views/etudiant/Details.cshtml"
           Write(Html.DisplayFor(model => model.nomEtudiant));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n    </div>\n    <div>\n         <label>prenomEtudiant</label>\n         <label>");
#nullable restore
#line 13 "/home/soufiane/Bureau/works/Projects/coreProject/Views/etudiant/Details.cshtml"
           Write(Html.DisplayFor(model => model.prenomEtudiant));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n    </div>\n    <div>\n         <label>adresseEtudiant</label>\n        <label>");
#nullable restore
#line 17 "/home/soufiane/Bureau/works/Projects/coreProject/Views/etudiant/Details.cshtml"
          Write(Html.DisplayFor(model => model.adresseEtudiant));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n    </div>\n    <div>\n         <label>phoneEtudiant</label>\n         <label>");
#nullable restore
#line 21 "/home/soufiane/Bureau/works/Projects/coreProject/Views/etudiant/Details.cshtml"
           Write(Html.DisplayFor(model => model.phoneEtudiant));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n    </div>\n    <div>\n         <label>codeFiliere</label>\n         <label>");
#nullable restore
#line 25 "/home/soufiane/Bureau/works/Projects/coreProject/Views/etudiant/Details.cshtml"
           Write(Html.DisplayFor(model => model.codeFiliere));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n    </div>\n    <div>\n         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "832dfa24445371572fcdc73894e697c3fbc485296242", async() => {
                    WriteLiteral("Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<coreProject.Models.Etudiant> Html { get; private set; }
    }
}
#pragma warning restore 1591