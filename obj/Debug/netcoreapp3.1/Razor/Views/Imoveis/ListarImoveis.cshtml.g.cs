#pragma checksum "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "874ad75cf780c94e9143a542b7dc79f4ab5d019d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Imoveis_ListarImoveis), @"mvc.1.0.view", @"/Views/Imoveis/ListarImoveis.cshtml")]
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
#line 1 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\_ViewImports.cshtml"
using mvImoveis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\_ViewImports.cshtml"
using mvImoveis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"874ad75cf780c94e9143a542b7dc79f4ab5d019d", @"/Views/Imoveis/ListarImoveis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57bbc64b50e05842b3c89e5b80f97497e5b9f6b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Imoveis_ListarImoveis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Imoveis>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
  
    Layout = "_LayoutColaborador";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
  
    ViewData["Title"] = "Listar Imoveis";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-5\">\r\n");
#nullable restore
#line 10 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
     foreach (Imoveis a in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-4 mb-5\">\r\n            <div class=\"card\">\r\n\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 281, "\"", 296, 1);
#nullable restore
#line 15 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
WriteAttributeValue("", 287, a.Imagem, 287, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">");
#nullable restore
#line 17 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
                                      Write(a.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h6 class=\"card-suntitle mb2 text-muted\">R$ ");
#nullable restore
#line 18 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
                                                           Write(a.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <p class=\"card-text text-justify\">");
#nullable restore
#line 19 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
                                                 Write(a.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div>\r\n                    <ul class=\"list-group list-group-flush text-center\">\r\n                        <li class=\"list-group-item\"><i class=\"fas fa-bed\" style=\"font-size: 20px;\"></i> ");
#nullable restore
#line 24 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
                                                                                                   Write(a.Quartos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | <i\r\n                            class=\"fas fa-bath\" style=\"font-size: 20px;\"></i> ");
#nullable restore
#line 25 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
                                                                         Write(a.Banheiros);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | <i class=\"fas fa-car\"\r\n                            style=\"font-size: 20px;\"></i> ");
#nullable restore
#line 26 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
                                                     Write(a.Garagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"list-group-item\">");
#nullable restore
#line 27 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
                                               Write(a.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 27 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
                                                           Write(a.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                </div>\r\n\r\n                <div class=\"card-body text-center\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1213, "\"", 1252, 2);
            WriteAttributeValue("", 1220, "/Imoveis/ExcluirImoveis?Id=", 1220, 27, true);
#nullable restore
#line 32 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
WriteAttributeValue("", 1247, a.Id, 1247, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a> |\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1291, "\"", 1329, 2);
            WriteAttributeValue("", 1298, "/Imoveis/Editarimoveis?Id=", 1298, 26, true);
#nullable restore
#line 33 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
WriteAttributeValue("", 1324, a.Id, 1324, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 37 "E:\arquivos Lucas\CURSO TÉCNICO SENAC\projeto integrador\trabalhos UC08 2.0\mvImoveis\Views\Imoveis\ListarImoveis.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Imoveis>> Html { get; private set; }
    }
}
#pragma warning restore 1591
