#pragma checksum "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49608b37ae7bfeb6d42ee39fdc011ca161fa236a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Index), @"mvc.1.0.view", @"/Views/Persona/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Persona/Index.cshtml", typeof(AspNetCore.Views_Persona_Index))]
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
#line 1 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\_ViewImports.cshtml"
using tareaDAS;

#line default
#line hidden
#line 2 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\_ViewImports.cshtml"
using tareaDAS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49608b37ae7bfeb6d42ee39fdc011ca161fa236a", @"/Views/Persona/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113d8451578b4c7b3dc5fe90d2ccdaa13d11ecaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<tareaDAS.Models.PersonaModels>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(123, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66963332e3a8408da791077fb9a1829d", async() => {
                BeginContext(146, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(160, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(253, 38, false);
#line 16 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(291, 41, true);
            WriteLiteral("\r\n            </th><th>\r\n                ");
            EndContext();
            BeginContext(333, 42, false);
#line 18 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(375, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(431, 45, false);
#line 21 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(476, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(532, 41, false);
#line 24 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cargo));

#line default
#line hidden
            EndContext();
            BeginContext(573, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(629, 43, false);
#line 27 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.salario));

#line default
#line hidden
            EndContext();
            BeginContext(672, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(790, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(839, 37, false);
#line 36 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(876, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(932, 41, false);
#line 39 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(973, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1029, 44, false);
#line 42 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1129, 40, false);
#line 45 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cargo));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1225, 42, false);
#line 48 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.salario));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1323, 48, false);
#line 51 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1392, 54, false);
#line 52 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1467, 52, false);
#line 53 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 56 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1558, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<tareaDAS.Models.PersonaModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
