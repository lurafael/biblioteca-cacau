#pragma checksum "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "840128e07e2a498c332f2a7536b254001d8762de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_List), @"mvc.1.0.view", @"/Views/Cliente/List.cshtml")]
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
#line 1 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\_ViewImports.cshtml"
using BibliotecaBookHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\_ViewImports.cshtml"
using BibliotecaBookHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"840128e07e2a498c332f2a7536b254001d8762de", @"/Views/Cliente/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fefd236ae0f0f286c77d970c752ba2d3e091ba1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BibliotecaBookHub.Models.DTO.ClienteDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
  
    ViewData["Title"] = "List";
    string login = Context.Session.GetString("_Login");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cadastro de Clientes</h1>\r\n\r\n");
#nullable restore
#line 11 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
 if (login != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "840128e07e2a498c332f2a7536b254001d8762de4120", async() => {
                WriteLiteral("Adicionar Cliente");
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
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 16 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-striped table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Fone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th> \r\n                Gerenciamento\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 39 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 55 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
                     if (login != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>\r\n                            ");
#nullable restore
#line 58 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
                       Write(Html.ActionLink("Atualizar", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 59 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
                       Write(Html.ActionLink("Detalhes", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 60 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
                       Write(Html.ActionLink("Exclusão", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n");
#nullable restore
#line 62 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Cliente\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BibliotecaBookHub.Models.DTO.ClienteDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
