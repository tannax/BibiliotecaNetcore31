#pragma checksum "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4df669dbf9b79488a148f40655ce738f9956702bca4ceb955fe1dd02d4e940bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4df669dbf9b79488a148f40655ce738f9956702bca4ceb955fe1dd02d4e940bd", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9b5db103c657cb4a6a953429a381ef558c4a1847f99d7078895a1a2ca751d365", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuarios_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcluirUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
  
    ViewData["Title"] = "Lista de Usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df669dbf9b79488a148f40655ce738f9956702bca4ceb955fe1dd02d4e940bd4844", async() => {
                WriteLiteral("Novo Usuário");
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
            WriteLiteral("\n</p>\n\n<table class=\"table table-striped\">\n    <thead>\n        <tr>\n            <th>ID</th>\n            <th>Nome</th>\n            <th>Login</th>\n            <th>Tipo</th>\n            <th>Ações</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 24 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
         if (Model != null) {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
             foreach (var usuario in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 27 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
                   Write(usuario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
                   Write(usuario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 29 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
                   Write(usuario.login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 30 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
                   Write(usuario.tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df669dbf9b79488a148f40655ce738f9956702bca4ceb955fe1dd02d4e940bd8074", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
                                                        WriteLiteral(usuario.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df669dbf9b79488a148f40655ce738f9956702bca4ceb955fe1dd02d4e940bd10308", async() => {
                WriteLiteral("Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
                                                         WriteLiteral(usuario.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 36 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
             
        }
        else {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td colspan=\"5\">Não há usuários cadastrados.</td>\n            </tr>\n");
#nullable restore
#line 42 "/home/krux/Documents/Progamming/aspnetCoreProjects/ProjEduBiblioteca/BibliotecaNetcore3.1/Views/Usuarios/ListaDeUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
