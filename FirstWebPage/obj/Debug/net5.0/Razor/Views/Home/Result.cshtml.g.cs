#pragma checksum "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\FirstWebPage\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac50803152b39587bc4fb5c9bf0efb85f040040d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac50803152b39587bc4fb5c9bf0efb85f040040d", @"/Views/Home/Result.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac50803152b39587bc4fb5c9bf0efb85f040040d2749", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <!-- Bootstrap CSS and JS -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
        integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""
        integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p""
        crossorigin=""anonymous""></script>

    <!-- Font Awesome Kit JS -->
    <script src=""https://kit.fontawesome.com/311afd7444.js"" crossorigin=""anonymous""></script>

    <!-- Page Title -->
    <title>PageTitle</title>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac50803152b39587bc4fb5c9bf0efb85f040040d4593", async() => {
                WriteLiteral("\r\n<div>\r\n    <div class=\"container-lg\">\r\n        <div class=\"row my-5 m-auto\">\r\n            <div class=\"card col-8 p-5\">\r\n");
                WriteLiteral(@"                <form action=""formsubmit"" method=""post"">
                    <div class=""row g-3 align-items-center mb-3 col-8 justify-content-between"">
                        <div class=""col-auto"">
                            <label for=""Name"" class=""col-form-label"">Your Name</label>
                        </div>
                        <div class=""col-auto"">
                            <input type=""text"" name='Name' id=""Name"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1511, "\"", 1532, 1);
#nullable restore
#line 36 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\FirstWebPage\Views\Home\Result.cshtml"
WriteAttributeValue("", 1519, ViewBag.Name, 1519, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                        </div>
                    </div>
                    <div class=""row g-3 align-items-center mb-3 col-8 justify-content-between"">
                        <div class=""col-auto"">
                            <label for=""DojoLocation"" class=""col-form-label"">Dojo Location</label>
                        </div>
                        <div class=""col-auto"">
                            <select name=""DojoLocation"" id=""DojoLocation"" class=""form-select"" disabled>
                                <option");
                BeginWriteAttribute("value", " value=\"", 2074, "\"", 2103, 1);
#nullable restore
#line 45 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\FirstWebPage\Views\Home\Result.cshtml"
WriteAttributeValue("", 2082, ViewBag.DojoLocation, 2082, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 45 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\FirstWebPage\Views\Home\Result.cshtml"
                                                                 Write(ViewBag.DojoLocation);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</option>
                            </select>
                        </div>
                    </div>
                    <div class=""row g-3 align-items-center mb-3 col-8 justify-content-between"">
                        <div class=""col-auto"">
                            <label for=""FavLang"" class=""col-form-label"">Favorite Language</label>
                        </div>
                        <div class=""col-auto"">
                            <select name=""FavLang"" id=""FavLang"" class=""form-select"" disabled>
                                <option");
                BeginWriteAttribute("value", " value=\"", 2694, "\"", 2718, 1);
#nullable restore
#line 55 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\FirstWebPage\Views\Home\Result.cshtml"
WriteAttributeValue("", 2702, ViewBag.FavLang, 2702, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 55 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\FirstWebPage\Views\Home\Result.cshtml"
                                                            Write(ViewBag.FavLang);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</option>
                            </select>
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label for=""exampleFormControlTextarea1"" class=""form-label"">Comment</label>
                        <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3""
                            name=""Comment"" readonly>");
#nullable restore
#line 62 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\FirstWebPage\Views\Home\Result.cshtml"
                                               Write(ViewBag.Comment);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                    </div>\r\n                    <br>\r\n                </form>\r\n                <a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n");
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
