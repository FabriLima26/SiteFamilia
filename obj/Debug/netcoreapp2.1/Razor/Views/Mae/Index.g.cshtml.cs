#pragma checksum "C:\Users\fabri\source\repos\SiteFamilia\Views\Mae\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c50571ec8394c4ba31eb18482f0990db5350455"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mae_Index), @"mvc.1.0.view", @"/Views/Mae/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mae/Index.cshtml", typeof(AspNetCore.Views_Mae_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c50571ec8394c4ba31eb18482f0990db5350455", @"/Views/Mae/Index.cshtml")]
    public class Views_Mae_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SiteFamilia.Models.Mae>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\fabri\source\repos\SiteFamilia\Views\Mae\Index.cshtml"
  
    ViewData["Title"] = "Perfil";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 394, true);
            WriteLiteral(@"


<h2>Perfil</h2>
<span><br>Total de registros:<br /> </span>
<table class=""table table-dark"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Primeiro</th>
            <th scope=""col"">Último</th>
            <th scope=""col"">Nickname</th>
        </tr>
    </thead>
    
        <tbody>
            <tr>
                <th scope=""row"">");
            EndContext();
            BeginContext(521, 10, false);
#line 23 "C:\Users\fabri\source\repos\SiteFamilia\Views\Mae\Index.cshtml"
                           Write(ViewBag.Id);

#line default
#line hidden
            EndContext();
            BeginContext(531, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(559, 12, false);
#line 24 "C:\Users\fabri\source\repos\SiteFamilia\Views\Mae\Index.cshtml"
               Write(ViewBag.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(571, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(599, 17, false);
#line 25 "C:\Users\fabri\source\repos\SiteFamilia\Views\Mae\Index.cshtml"
               Write(ViewBag.Sobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(616, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 667, "\"", 700, 2);
            WriteAttributeValue("", 674, "/mae/atualizar/", 674, 15, true);
#line 27 "C:\Users\fabri\source\repos\SiteFamilia\Views\Mae\Index.cshtml"
WriteAttributeValue("", 689, ViewBag.Id, 689, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(701, 47, true);
            WriteLiteral(" class=\"btn\">Editar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 748, "\"", 779, 2);
            WriteAttributeValue("", 755, "/mae/excluir/", 755, 13, true);
#line 28 "C:\Users\fabri\source\repos\SiteFamilia\Views\Mae\Index.cshtml"
WriteAttributeValue("", 768, ViewBag.Id, 768, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(780, 102, true);
            WriteLiteral(" class=\"btn\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    \r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SiteFamilia.Models.Mae>> Html { get; private set; }
    }
}
#pragma warning restore 1591
