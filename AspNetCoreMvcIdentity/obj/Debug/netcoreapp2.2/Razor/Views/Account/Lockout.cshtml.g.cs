#pragma checksum "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Account\Lockout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d79ba2b2824a18d06997ef826ec60d3e88795991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Lockout), @"mvc.1.0.view", @"/Views/Account/Lockout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Lockout.cshtml", typeof(AspNetCore.Views_Account_Lockout))]
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
#line 1 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\_ViewImports.cshtml"
using AspNetCoreMvcIdentity;

#line default
#line hidden
#line 3 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\_ViewImports.cshtml"
using AspNetCoreMvcIdentity.Models;

#line default
#line hidden
#line 4 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\_ViewImports.cshtml"
using AspNetCoreMvcIdentity.Models.AccountViewModels;

#line default
#line hidden
#line 5 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\_ViewImports.cshtml"
using AspNetCoreMvcIdentity.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d79ba2b2824a18d06997ef826ec60d3e88795991", @"/Views/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e1aa6d9fb3442c0f9f807e3f2c4ae2617a62994", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Lockout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Account\Lockout.cshtml"
  
    ViewData["Title"] = "Locked out";

#line default
#line hidden
            BeginContext(43, 38, true);
            WriteLiteral("\n<header>\n    <h2 class=\"text-danger\">");
            EndContext();
            BeginContext(82, 17, false);
#line 6 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Account\Lockout.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(99, 105, true);
            WriteLiteral("</h2>\n    <p class=\"text-danger\">This account has been locked out, please try again later.</p>\n</header>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
