#pragma checksum "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f3695a7b89a77e1872172ba331eff3bf9f72c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Delete), @"mvc.1.0.view", @"/Views/Persona/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Persona/Delete.cshtml", typeof(AspNetCore.Views_Persona_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8f3695a7b89a77e1872172ba331eff3bf9f72c0", @"/Views/Persona/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113d8451578b4c7b3dc5fe90d2ccdaa13d11ecaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tareaDAS.Models.PersonaModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(82, 255, true);
            WriteLiteral("\r\n<h2>Borrar</h2>\r\n\r\n<h3>La información que se elimine, no se puede recuperar. </h3>\r\n<h4>Si tiene alguna duda, llame a soporte tecnico</h4>\r\n<div>\r\n    <h4>Formulario de Borrado</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(338, 38, false);
#line 16 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(376, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(420, 34, false);
#line 19 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(454, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(500, 42, false);
#line 23 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(542, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(586, 38, false);
#line 26 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayFor(model => model.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(624, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(668, 44, false);
#line 29 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.apellido));

#line default
#line hidden
            EndContext();
            BeginContext(712, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(756, 40, false);
#line 32 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayFor(model => model.apellido));

#line default
#line hidden
            EndContext();
            BeginContext(796, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(842, 45, false);
#line 36 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(887, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(931, 41, false);
#line 39 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayFor(model => model.direccion));

#line default
#line hidden
            EndContext();
            BeginContext(972, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1016, 40, false);
#line 42 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.area));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1100, 36, false);
#line 45 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayFor(model => model.area));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 33, true);
            WriteLiteral("\r\n        </dd><dt>\r\n            ");
            EndContext();
            BeginContext(1170, 41, false);
#line 47 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.cargo));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1255, 37, false);
#line 50 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayFor(model => model.cargo));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1336, 43, false);
#line 53 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.salario));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1423, 39, false);
#line 56 "C:\Users\danie\Documents\GitHub\tareaDAS\tareaDAS\Views\Persona\Delete.cshtml"
       Write(Html.DisplayFor(model => model.salario));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1500, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38cd6d3841fb438ab205e3bdba703ef5", async() => {
                BeginContext(1526, 93, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Borrar Registro\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1619, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a5de029798148b58432b3c5bb251ef7", async() => {
                    BeginContext(1641, 18, true);
                    WriteLiteral("Regresar a listado");
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
                BeginContext(1663, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1676, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tareaDAS.Models.PersonaModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
