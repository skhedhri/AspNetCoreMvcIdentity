#pragma checksum "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42b9aae622dba70eba965167da5c1ee9b27e11d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Index), @"mvc.1.0.view", @"/Views/Forum/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forum/Index.cshtml", typeof(AspNetCore.Views_Forum_Index))]
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
#line 2 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42b9aae622dba70eba965167da5c1ee9b27e11d6", @"/Views/Forum/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e1aa6d9fb3442c0f9f807e3f2c4ae2617a62994", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCoreMvcIdentity.Models.ForumViewModels.ForumIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 1.5em"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(207, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(246, 25, true);
            WriteLiteral("\n<h1>List of forums</h1>\n");
            EndContext();
#line 11 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
 if (User.IsInRole("Admin"))
{
    

#line default
#line hidden
            BeginContext(307, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(311, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b9aae622dba70eba965167da5c1ee9b27e11d66516", async() => {
                BeginContext(367, 16, true);
                WriteLiteral("Create new Forum");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(387, 23, true);
            WriteLiteral("\n    <br />\n    <br />\n");
            EndContext();
#line 17 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
  

}

#line default
#line hidden
            BeginContext(416, 63, true);
            WriteLiteral("\n<table class=\"table table-bordered table-hover\">\n\n    <tbody>\n");
            EndContext();
#line 24 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
         foreach (var forum in Model.ForumList)
        {

#line default
#line hidden
            BeginContext(537, 135, true);
            WriteLiteral("            <tr>\n                <td>\n                    <div class=\"row\">\n                        <div class=\"col-1 text-center\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 672, "\"", 698, 1);
#line 29 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
WriteAttributeValue("", 678, forum.ForumImageUrl, 678, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(699, 104, true);
            WriteLiteral(" style=\"width: 40px\" /></div>\n                        <div class=\"col-10 \">\n                            ");
            EndContext();
            BeginContext(803, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b9aae622dba70eba965167da5c1ee9b27e11d69307", async() => {
                BeginContext(900, 33, true);
                WriteLiteral("\n                                ");
                EndContext();
                BeginContext(934, 11, false);
#line 32 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
                           Write(forum.Title);

#line default
#line hidden
                EndContext();
                BeginContext(945, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
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
#line 31 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
                                                                                                      WriteLiteral(forum.Id);

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
            BeginContext(978, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 35 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
                             if (forum.HasRecentPost)
                            {

#line default
#line hidden
            BeginContext(1064, 75, true);
            WriteLiteral("                                <div class=\"badge badge-success\">New</div>\n");
            EndContext();
#line 38 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1169, 64, true);
            WriteLiteral("                            <br />\n\n                            ");
            EndContext();
            BeginContext(1234, 17, false);
#line 41 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
                       Write(forum.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1251, 86, true);
            WriteLiteral("\n                            <div class=\"text-muted\">\n                                ");
            EndContext();
            BeginContext(1338, 19, false);
#line 43 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
                           Write(forum.NumberOfPosts);

#line default
#line hidden
            EndContext();
            BeginContext(1357, 42, true);
            WriteLiteral(" Posts by\n                                ");
            EndContext();
            BeginContext(1400, 19, false);
#line 44 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
                           Write(forum.NumberOfUsers);

#line default
#line hidden
            EndContext();
            BeginContext(1419, 42, true);
            WriteLiteral(" Users\n                            </div>\n");
            EndContext();
#line 46 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
                             if (User.IsInRole("Admin"))
                            {

#line default
#line hidden
            BeginContext(1548, 71, true);
            WriteLiteral("                                <br />\n                                ");
            EndContext();
            BeginContext(1619, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b9aae622dba70eba965167da5c1ee9b27e11d614919", async() => {
                BeginContext(1667, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"
                                                         WriteLiteral(forum.Id);

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
            BeginContext(1677, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 50 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(1709, 105, true);
            WriteLiteral("                        </div>\n\n\n\n\n\n\n\n                    </div>\n                </td>\n            </tr>\n");
            EndContext();
#line 63 "D:\Polytech\2eme\CSharp\Project\Forum-ASP.NET-Core-master\AspNetCoreMvcIdentity\Views\Forum\Index.cshtml"


        }

#line default
#line hidden
            BeginContext(1826, 21, true);
            WriteLiteral("    </tbody>\n</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreMvcIdentity.Models.ForumViewModels.ForumIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591