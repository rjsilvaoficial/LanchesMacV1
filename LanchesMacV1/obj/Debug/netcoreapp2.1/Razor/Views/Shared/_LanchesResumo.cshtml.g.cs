#pragma checksum "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\Shared\_LanchesResumo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f449f67f63fc86d4e8c2bd435938d0c21f3cb49d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LanchesResumo), @"mvc.1.0.view", @"/Views/Shared/_LanchesResumo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LanchesResumo.cshtml", typeof(AspNetCore.Views_Shared__LanchesResumo))]
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
#line 1 "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\_ViewImports.cshtml"
using LanchesMacV1;

#line default
#line hidden
#line 2 "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\_ViewImports.cshtml"
using LanchesMacV1.Models;

#line default
#line hidden
#line 3 "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\_ViewImports.cshtml"
using LanchesMacV1.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f449f67f63fc86d4e8c2bd435938d0c21f3cb49d", @"/Views/Shared/_LanchesResumo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2960f3d000e97543b6a567e2acaf485c89aca8ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LanchesResumo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lanche>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banner1.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 81, true);
            WriteLiteral("\r\n<div class=\"col-sm-4 col-md-4 col-lg-4\">\r\n    <div class=\"thumbnail\">\r\n        ");
            EndContext();
            BeginContext(96, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8033cdd3df5545b69a599b450027f143", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(157, 71, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"caption\">\r\n        <h3 class=\"pull-righ\">");
            EndContext();
            BeginContext(229, 25, false);
#line 8 "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\Shared\_LanchesResumo.cshtml"
                         Write(Model.Preco.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(254, 19, true);
            WriteLiteral("</h3>\r\n        <h3>");
            EndContext();
            BeginContext(274, 10, false);
#line 9 "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\Shared\_LanchesResumo.cshtml"
       Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(284, 26, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <p>");
            EndContext();
            BeginContext(311, 20, false);
#line 11 "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\Shared\_LanchesResumo.cshtml"
  Write(Model.DescricaoCurta);

#line default
#line hidden
            EndContext();
            BeginContext(331, 12, true);
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lanche> Html { get; private set; }
    }
}
#pragma warning restore 1591
