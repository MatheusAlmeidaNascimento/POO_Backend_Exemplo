#pragma checksum "C:\Users\dev\Desktop\POO Backend Rec3\Views\Musico\MusicoFoda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46a01ecf6379fb3455277d32ce3dc4532134ec8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musico_MusicoFoda), @"mvc.1.0.view", @"/Views/Musico/MusicoFoda.cshtml")]
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
#line 1 "C:\Users\dev\Desktop\POO Backend Rec3\Views\_ViewImports.cshtml"
using POO_Backend_Rec3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dev\Desktop\POO Backend Rec3\Views\_ViewImports.cshtml"
using POO_Backend_Rec3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a01ecf6379fb3455277d32ce3dc4532134ec8d", @"/Views/Musico/MusicoFoda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a4bcd29d02e86dcd8e277ab5166a89a98617ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Musico_MusicoFoda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Músico Fodão - ");
#nullable restore
#line 1 "C:\Users\dev\Desktop\POO Backend Rec3\Views\Musico\MusicoFoda.cshtml"
              Write(ViewBag.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>");
#nullable restore
#line 3 "C:\Users\dev\Desktop\POO Backend Rec3\Views\Musico\MusicoFoda.cshtml"
Write(ViewBag.Saudacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
