#pragma checksum "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\Lanche\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32ee641c7b2623a38ef1da9427b93e92be2e7614"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lanche_List), @"mvc.1.0.view", @"/Views/Lanche/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lanche/List.cshtml", typeof(AspNetCore.Views_Lanche_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ee641c7b2623a38ef1da9427b93e92be2e7614", @"/Views/Lanche/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2960f3d000e97543b6a567e2acaf485c89aca8ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Lanche_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LancheListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 12, true);
            WriteLiteral(" \r\n<div><h3>");
            EndContext();
            BeginContext(42, 20, false);
#line 3 "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\Lanche\List.cshtml"
    Write(Model.CategoriaAtual);

#line default
#line hidden
            EndContext();
            BeginContext(62, 17, true);
            WriteLiteral("</h3></div>\r\n\r\n\r\n");
            EndContext();
#line 6 "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\Lanche\List.cshtml"
 foreach (var lanche in Model.Lanches)
{
    

#line default
#line hidden
            BeginContext(127, 38, false);
#line 8 "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\Lanche\List.cshtml"
Write(Html.Partial("_LanchesResumo", lanche));

#line default
#line hidden
            EndContext();
#line 8 "C:\Users\robso\source\repos\LanchesMacV1\LanchesMacV1\Views\Lanche\List.cshtml"
                                           
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LancheListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
