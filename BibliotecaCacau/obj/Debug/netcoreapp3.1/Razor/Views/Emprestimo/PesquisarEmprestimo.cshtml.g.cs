#pragma checksum "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "094bbc08a4ce036984791f9e5853979da760fca0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_PesquisarEmprestimo), @"mvc.1.0.view", @"/Views/Emprestimo/PesquisarEmprestimo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094bbc08a4ce036984791f9e5853979da760fca0", @"/Views/Emprestimo/PesquisarEmprestimo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fefd236ae0f0f286c77d970c752ba2d3e091ba1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_PesquisarEmprestimo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BibliotecaCacau.Models.DTO.ConsultaEmprestimoDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Consulta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
  
    ViewData["Title"] = "PesquisarEmprestimo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PesquisarEmprestimo</h1>\r\n\r\n<div>\r\n    <h4>ConsultaEmprestimoDTO</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayNameFor(model => model.Livro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayFor(model => model.Livro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayNameFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayNameFor(model => model.Editora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayFor(model => model.Editora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayFor(model => model.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayNameFor(model => model.DataEmprestimo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayFor(model => model.DataEmprestimo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayNameFor(model => model.DataDevolucao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayFor(model => model.DataDevolucao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayNameFor(model => model.DataDevolucaoEfetiva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayFor(model => model.DataDevolucaoEfetiva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusLivro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayFor(model => model.StatusLivro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayNameFor(model => model.LoginBibliotecario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
       Write(Html.DisplayFor(model => model.LoginBibliotecario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 76 "C:\github\biblioteca-cacau\BibliotecaCacau\Views\Emprestimo\PesquisarEmprestimo.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094bbc08a4ce036984791f9e5853979da760fca010802", async() => {
                WriteLiteral("Voltar");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BibliotecaCacau.Models.DTO.ConsultaEmprestimoDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
