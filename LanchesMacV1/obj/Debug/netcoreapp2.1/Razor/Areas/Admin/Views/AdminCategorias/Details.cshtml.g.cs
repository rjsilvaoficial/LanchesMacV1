#pragma checksum "C:\Users\robso\Desktop\LanchesMacV1\LanchesMacV1\LanchesMacV1\Areas\Admin\Views\AdminCategorias\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a267c638bf1cf6d1e90d18f8561b78b57b8e5499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminCategorias_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminCategorias/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdminCategorias/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdminCategorias_Details))]
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
#line 1 "C:\Users\robso\Desktop\LanchesMacV1\LanchesMacV1\LanchesMacV1\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMacV1;

#line default
#line hidden
#line 2 "C:\Users\robso\Desktop\LanchesMacV1\LanchesMacV1\LanchesMacV1\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMacV1.Models;

#line default
#line hidden
#line 3 "C:\Users\robso\Desktop\LanchesMacV1\LanchesMacV1\LanchesMacV1\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMacV1.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a267c638bf1cf6d1e90d18f8561b78b57b8e5499", @"/Areas/Admin/Views/AdminCategorias/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab11b9fa53c6d8cf73535a05ab93c54d2181694", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminCategorias_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LanchesMacV1.Models.Categoria>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\robso\Desktop\LanchesMacV1\LanchesMacV1\LanchesMacV1\Areas\Admin\Views\AdminCategorias\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 123, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Categoria</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(207, 40, false);
#line 14 "C:\Users\robso\Desktop\LanchesMacV1\LanchesMacV1\LanchesMacV1\Areas\Admin\Views\AdminCategorias\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(247, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(291, 36, false);
#line 17 "C:\Users\robso\Desktop\LanchesMacV1\LanchesMacV1\LanchesMacV1\Areas\Admin\Views\AdminCategorias\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(327, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(371, 45, false);
#line 20 "C:\Users\robso\Desktop\LanchesMacV1\LanchesMacV1\LanchesMacV1\Areas\Admin\Views\AdminCategorias\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(416, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(460, 41, false);
#line 23 "C:\Users\robso\Desktop\LanchesMacV1\LanchesMacV1\LanchesMacV1\Areas\Admin\Views\AdminCategorias\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(501, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(548, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78cd910433d4485c8be95e74fb006eff", async() => {
                BeginContext(603, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\robso\Desktop\LanchesMacV1\LanchesMacV1\LanchesMacV1\Areas\Admin\Views\AdminCategorias\Details.cshtml"
                           WriteLiteral(Model.CategoriaId);

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
            BeginContext(611, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(619, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bbc083322f64dad93242fa3ed499540", async() => {
                BeginContext(641, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(657, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LanchesMacV1.Models.Categoria> Html { get; private set; }
    }
}
#pragma warning restore 1591
