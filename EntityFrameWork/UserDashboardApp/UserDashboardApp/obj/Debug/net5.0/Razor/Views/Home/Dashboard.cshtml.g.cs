#pragma checksum "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6695384c332e91db1411aaf9519d22d33e6e44ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\_ViewImports.cshtml"
using UserDashboardApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\_ViewImports.cshtml"
using UserDashboardApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6695384c332e91db1411aaf9519d22d33e6e44ea", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8798942b92e8d681e5e70d6e19af038c706e177", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row my-5 flex-column"">
    <h3>All Users</h3>
    <hr/>
    <div class=""my-4"">
        <table class=""table table-striped table-light"">
            <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Created At</th>
                <th scope=""col"">User Level</th>
                <th scope=""col"">Action</th>
            </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
              
                foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 26 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                                   Write(user.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6695384c332e91db1411aaf9519d22d33e6e44ea6050", async() => {
#nullable restore
#line 27 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                                                                                                         Write(user.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 27 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                                                                                                                         Write(user.LastName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-UserId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                                                              WriteLiteral(user.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                       Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                       Write(user.CreatedAt.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                       Write(user.UserLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        \r\n                        <td>\r\n");
#nullable restore
#line 33 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                             if (ViewBag.UserLoggedIn.UserLevel == "Admin" || ViewBag.UserLoggedIn.UserId == user.UserId)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6695384c332e91db1411aaf9519d22d33e6e44ea10764", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-UserId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                                                                        WriteLiteral(user.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n");
#nullable restore
#line 36 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                             if (ViewBag.UserLoggedIn.UserLevel == "Admin")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6695384c332e91db1411aaf9519d22d33e6e44ea13894", async() => {
                WriteLiteral("Remove");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-UserId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                                                                       WriteLiteral(user.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n");
#nullable restore
#line 40 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 43 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\UserDashboardApp\UserDashboardApp\Views\Home\Dashboard.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
