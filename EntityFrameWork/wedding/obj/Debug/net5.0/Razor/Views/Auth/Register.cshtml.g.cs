#pragma checksum "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Auth\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aa88812d157fc20daf38d3bdeef9f675bf129e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Register), @"mvc.1.0.view", @"/Views/Auth/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aa88812d157fc20daf38d3bdeef9f675bf129e4", @"/Views/Auth/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85235f96856bffe5333adb357215f3e00a534253", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "registerPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Auth\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"position-absolute top-50 start-50 translate-middle\" style=\"width:320px;\">\r\n");
#nullable restore
#line 8 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Auth\Register.cshtml"
      
        if (TempData["LoginError"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert bg-red-300 alert-dismissible fade show\" role=\"alert\"");
            BeginWriteAttribute("id", " id=\"", 294, "\"", 322, 1);
#nullable restore
#line 11 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Auth\Register.cshtml"
WriteAttributeValue("", 299, TempData["LoginError"], 299, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <strong>Hey!</strong> Something went wrong.\r\n                <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\r\n            </div>\r\n");
#nullable restore
#line 15 "D:\PROJECS\Coding Dojo\C# Stack\c#_stack_git\CSHARP-Coding-dojo\EntityFrameWork\Wedding\Views\Auth\Register.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"card p-3 m-auto border-light border-3 rounded-4 bg-primary shadow-lg\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7aa88812d157fc20daf38d3bdeef9f675bf129e46273", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <p class=\" my-2 w-100 text-center m-auto\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7aa88812d157fc20daf38d3bdeef9f675bf129e47467", async() => {
                WriteLiteral("Already an user? <b>Login</b> instead");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </p>
</div>

<script>
let body = document.querySelector('body');
body.classList.add('bg-gray-200');

let btnsubmit = document.querySelector('#btnsubmit-register-page');
btnsubmit.classList.remove('btn-primary');
btnsubmit.classList.add('btn-outline-light');

let logintext = document.querySelector('#registertext-reg-page');
logintext.classList.add('text-light');

if(document.querySelector('#emailnotfound')){
    document.querySelector('#floatingInput').classList.add('is-invalid');
}
if(document.querySelector('#passwordincorrect')){
    document.querySelector('#floatingPassword').classList.add('is-invalid');
}

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
