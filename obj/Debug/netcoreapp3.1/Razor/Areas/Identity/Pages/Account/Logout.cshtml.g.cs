#pragma checksum "/home/soufiane/Bureau/works/Projects/coreProject/Areas/Identity/Pages/Account/Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9460937a7be5d958c3e7aa259622a74fb210527"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
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
#line 1 "/home/soufiane/Bureau/works/Projects/coreProject/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/soufiane/Bureau/works/Projects/coreProject/Areas/Identity/Pages/_ViewImports.cshtml"
using coreProject.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/soufiane/Bureau/works/Projects/coreProject/Areas/Identity/Pages/_ViewImports.cshtml"
using coreProject.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/soufiane/Bureau/works/Projects/coreProject/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using coreProject.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9460937a7be5d958c3e7aa259622a74fb210527", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df339171f8842b86f8c01ef51fb86724b1ecdad2", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ac229cdf8b2436f9a1452f12594f5d2be53975", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/soufiane/Bureau/works/Projects/coreProject/Areas/Identity/Pages/Account/Logout.cshtml"
  
    ViewData["Title"] = "Log out";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <h1>");
#nullable restore
#line 8 "/home/soufiane/Bureau/works/Projects/coreProject/Areas/Identity/Pages/Account/Logout.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>You have successfully logged out of the application.</p>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<coreProject.Areas.Identity.Pages.Account.LogoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<coreProject.Areas.Identity.Pages.Account.LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<coreProject.Areas.Identity.Pages.Account.LogoutModel>)PageContext?.ViewData;
        public coreProject.Areas.Identity.Pages.Account.LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591