#pragma checksum "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Manage\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4872bcc2fc03883633526244d5c6977610b3f3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__StatusMessage), @"mvc.1.0.view", @"/Views/Manage/_StatusMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_StatusMessage.cshtml", typeof(AspNetCore.Views_Manage__StatusMessage))]
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
#line 1 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Manage\_ViewImports.cshtml"
using AspNetCoreMvcIdentity.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4872bcc2fc03883633526244d5c6977610b3f3bd", @"/Views/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e1aa6d9fb3442c0f9f807e3f2c4ae2617a62994", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69f1644d430d0de488f55296b6af97b704c492a9", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            BeginContext(131, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 139, "\"", 196, 4);
            WriteAttributeValue("", 147, "alert", 147, 5, true);
            WriteAttributeValue(" ", 152, "alert-", 153, 7, true);
#line 6 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Manage\_StatusMessage.cshtml"
WriteAttributeValue("", 159, statusMessageClass, 159, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 178, "alert-dismissible", 179, 18, true);
            EndWriteAttribute();
            BeginContext(197, 156, true);
            WriteLiteral(" role=\"alert\">\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n        ");
            EndContext();
            BeginContext(354, 5, false);
#line 8 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Manage\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(359, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
#line 10 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Manage\_StatusMessage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
