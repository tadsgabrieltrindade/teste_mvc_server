#pragma checksum "C:\Users\A0152226\Downloads\teste_mvc_server\Server Teste\Server Teste\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4de32109cac43f64c0bf78c15747b8677a9fec93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\A0152226\Downloads\teste_mvc_server\Server Teste\Server Teste\Views\_ViewImports.cshtml"
using Server_Teste;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\A0152226\Downloads\teste_mvc_server\Server Teste\Server Teste\Views\_ViewImports.cshtml"
using Server_Teste.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de32109cac43f64c0bf78c15747b8677a9fec93", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc86486424ffcfb69ed16cbb61586ad8abb663a0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PessoaModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\A0152226\Downloads\teste_mvc_server\Server Teste\Server Teste\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Seja bem vindo página ");
#nullable restore
#line 8 "C:\Users\A0152226\Downloads\teste_mvc_server\Server Teste\Server Teste\Views\Home\Index.cshtml"
                        Write(Model.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\A0152226\Downloads\teste_mvc_server\Server Teste\Server Teste\Views\Home\Index.cshtml"
                                    Write(Model.sobrenome);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\A0152226\Downloads\teste_mvc_server\Server Teste\Server Teste\Views\Home\Index.cshtml"
  Write(Model.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PessoaModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591