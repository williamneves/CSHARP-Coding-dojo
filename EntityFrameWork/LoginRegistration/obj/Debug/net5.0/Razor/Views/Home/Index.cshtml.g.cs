#pragma checksum "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\LoginRegistration\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc3c5debc223ad67a42af0df764083e25818ce3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\LoginRegistration\Views\_ViewImports.cshtml"
using LoginRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\LoginRegistration\Views\_ViewImports.cshtml"
using LoginRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc3c5debc223ad67a42af0df764083e25818ce3a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b8b69ac1923d039b18bb6580c27c9405e8eb6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\LoginRegistration\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Login&Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"m-auto my-2 w-50\">\r\n    <p class=\'fw-bold text-info text-center\'> ");
#nullable restore
#line 6 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\LoginRegistration\Views\Home\Index.cshtml"
                                         Write(TempData["Logout"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    </div>\r\n");
#nullable restore
#line 9 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\LoginRegistration\Views\Home\Index.cshtml"
    if(TempData["AuthError"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-5 text-center m-auto my-3"">
    <svg xmlns=""http://www.w3.org/2000/svg"" style=""display: none;"">
  <symbol id=""check-circle-fill"" fill=""currentColor"" viewBox=""0 0 16 16"">
    <path d=""M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z""/>
  </symbol>
  <symbol id=""info-fill"" fill=""currentColor"" viewBox=""0 0 16 16"">
    <path d=""M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zm.93-9.412-1 4.705c-.07.34.029.533.304.533.194 0 .487-.07.686-.246l-.088.416c-.287.346-.92.598-1.465.598-.703 0-1.002-.422-.808-1.319l.738-3.468c.064-.293.006-.399-.287-.47l-.451-.081.082-.381 2.29-.287zM8 5.5a1 1 0 1 1 0-2 1 1 0 0 1 0 2z""/>
  </symbol>
  <symbol id=""exclamation-triangle-fill"" fill=""currentColor"" viewBox=""0 0 16 16"">
    <path d=""M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 ");
            WriteLiteral(@"3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z""/>
  </symbol>
</svg>

<div class=""alert alert-warning d-flex align-items-center"" role=""alert"">
  <svg class=""bi flex-shrink-0 me-2"" width=""24"" height=""24"" role=""img"" aria-label=""Info:""><use xlink:href=""#info-fill""/></svg>
  <div>
    ");
#nullable restore
#line 27 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\LoginRegistration\Views\Home\Index.cshtml"
Write(TempData["AuthError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </div>\r\n</div>\r\n</div>\r\n");
#nullable restore
#line 31 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\LoginRegistration\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1>Index Page</h1>    \r\n</div>");
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
