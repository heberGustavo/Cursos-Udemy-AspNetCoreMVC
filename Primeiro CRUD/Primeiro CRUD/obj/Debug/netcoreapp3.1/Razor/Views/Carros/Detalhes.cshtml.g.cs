#pragma checksum "C:\Users\SuporteSQ-06\Desktop\projetos_heber\Cursos Udemy\MVC\Primeiro CRUD\Primeiro CRUD\Views\Carros\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dde5da0317c80aebd0d76598cbe02ff8ff87260"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carros_Detalhes), @"mvc.1.0.view", @"/Views/Carros/Detalhes.cshtml")]
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
#line 1 "C:\Users\SuporteSQ-06\Desktop\projetos_heber\Cursos Udemy\MVC\Primeiro CRUD\Primeiro CRUD\Views\_ViewImports.cshtml"
using Primeiro_CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SuporteSQ-06\Desktop\projetos_heber\Cursos Udemy\MVC\Primeiro CRUD\Primeiro CRUD\Views\_ViewImports.cshtml"
using Primeiro_CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dde5da0317c80aebd0d76598cbe02ff8ff87260", @"/Views/Carros/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85fce54bd1a5eaede4e88cb7ba591b2a8a03c44b", @"/Views/_ViewImports.cshtml")]
    public class Views_Carros_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Primeiro_CRUD.Models.Carro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SuporteSQ-06\Desktop\projetos_heber\Cursos Udemy\MVC\Primeiro CRUD\Primeiro CRUD\Views\Carros\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <strong>Carro:</strong> ");
#nullable restore
#line 12 "C:\Users\SuporteSQ-06\Desktop\projetos_heber\Cursos Udemy\MVC\Primeiro CRUD\Primeiro CRUD\Views\Carros\Detalhes.cshtml"
                               Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <strong>Marca:</strong> ");
#nullable restore
#line 17 "C:\Users\SuporteSQ-06\Desktop\projetos_heber\Cursos Udemy\MVC\Primeiro CRUD\Primeiro CRUD\Views\Carros\Detalhes.cshtml"
                               Write(Model.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <strong>Ano:</strong> ");
#nullable restore
#line 22 "C:\Users\SuporteSQ-06\Desktop\projetos_heber\Cursos Udemy\MVC\Primeiro CRUD\Primeiro CRUD\Views\Carros\Detalhes.cshtml"
                             Write(Model.Ano);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Primeiro_CRUD.Models.Carro> Html { get; private set; }
    }
}
#pragma warning restore 1591