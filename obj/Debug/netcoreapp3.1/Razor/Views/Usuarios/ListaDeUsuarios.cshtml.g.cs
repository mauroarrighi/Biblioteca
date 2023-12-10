#pragma checksum "C:\SenacEad\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d659db336c3f52b8134bbbd6c72e71b400e09e1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
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
#line 1 "C:\SenacEad\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SenacEad\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d659db336c3f52b8134bbbd6c72e71b400e09e1a", @"/Views/Usuarios/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac979cfa6f9c2014e1ebeda333546c494974b6fb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuarios_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Usuários cadastrados no sistema</h1>\n\n<p class=\"text-danger\">");
#nullable restore
#line 4 "C:\SenacEad\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th scope=\"row\">Nome</th>\n            <th scope=\"row\">Login</th>\n            <th scope=\"row\">Tipo</th>\n        </tr>\n    </thead>\n\n    <tbody>\n");
#nullable restore
#line 16 "C:\SenacEad\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
         foreach(Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 19 "C:\SenacEad\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 20 "C:\SenacEad\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
               Write(u.login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 21 "C:\SenacEad\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                 if(u.tipo==Usuario.ADMIN)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <TD>Administrador</TD>\n");
#nullable restore
#line 24 "C:\SenacEad\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\n");
#nullable restore
#line 28 "C:\SenacEad\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 684, "\"", 713, 2);
            WriteAttributeValue("", 691, "editarUsuario?id=", 691, 17, true);
#nullable restore
#line 30 "C:\SenacEad\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 708, u.Id, 708, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 753, "\"", 783, 2);
            WriteAttributeValue("", 760, "ExcluirUsuario?id=", 760, 18, true);
#nullable restore
#line 31 "C:\SenacEad\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 778, u.Id, 778, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a></td>\n            </tr>\n");
#nullable restore
#line 33 "C:\SenacEad\Biblioteca\Views\Usuarios\ListaDeUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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