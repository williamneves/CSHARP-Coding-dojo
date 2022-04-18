#pragma checksum "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37666d7b37a12c8550529a52ea9d947c4cb2278b"
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
#line 1 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\_ViewImports.cshtml"
using Wedding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\_ViewImports.cshtml"
using Wedding.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37666d7b37a12c8550529a52ea9d947c4cb2278b", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85235f96856bffe5333adb357215f3e00a534253", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeddingsList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row mt-3\">\r\n<h2 class=\"text-center my-3\">Welcome to the Wedding Planner</h2>\r\n<hr/>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
<table class=""table table-striped table-light"">
    <thead>
    <tr>
        <th scope=""col"">Wedding</th>
        <th scope=""col"">Date</th>
        <th scope=""col"">Guests</th>
        <th scope=""col"">Actions</th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 74 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
      
        foreach (var wedding in @Model.ListOfWeddings)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 2160, "\"", 2194, 2);
            WriteAttributeValue("", 2167, "/Wedding/", 2167, 9, true);
#nullable restore
#line 78 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2176, wedding.WeddingId, 2176, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
                                                     Write(wedding.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" & ");
#nullable restore
#line 78 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
                                                                          Write(wedding.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td>");
#nullable restore
#line 79 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
               Write(wedding.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 80 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
               Write(wedding.Guests.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 82 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
                     if(wedding.UserId == ViewBag.UserLoggedIn.UserId)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 2497, "\"", 2530, 2);
            WriteAttributeValue("", 2504, "/Delete/", 2504, 8, true);
#nullable restore
#line 84 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2512, wedding.WeddingId, 2512, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n");
#nullable restore
#line 85 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
                    }
                    else if(wedding.Guests.Any(g => g.UserId == ViewBag.UserLoggedIn.UserId))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 2711, "\"", 2744, 2);
            WriteAttributeValue("", 2718, "/UnJoin/", 2718, 8, true);
#nullable restore
#line 88 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2726, wedding.WeddingId, 2726, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Un-Join</a>\r\n");
#nullable restore
#line 89 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 2853, "\"", 2884, 2);
            WriteAttributeValue("", 2860, "/Join/", 2860, 6, true);
#nullable restore
#line 92 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 2866, wedding.WeddingId, 2866, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Join</a>\r\n");
#nullable restore
#line 93 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 96 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Home\Dashboard.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeddingsList> Html { get; private set; }
    }
}
#pragma warning restore 1591
