#pragma checksum "C:\Users\LuisMauricio\Desktop\PM - PRACTICA - Mauricio Falla\PM - PRACTICA - Mauricio Falla\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c3e3def39d48fa2ffdb360cd9640facf1ffc7a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c3e3def39d48fa2ffdb360cd9640facf1ffc7a6", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PM___PRACTICA___Mauricio_Falla.Models.Producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 30, true);
            WriteLiteral("\r\n<h1>Home (Usuario Logueado: ");
            EndContext();
            BeginContext(92, 15, false);
#line 3 "C:\Users\LuisMauricio\Desktop\PM - PRACTICA - Mauricio Falla\PM - PRACTICA - Mauricio Falla\Views\Home\Index.cshtml"
                       Write(ViewBag.Usuario);

#line default
#line hidden
            EndContext();
            BeginContext(107, 10, true);
            WriteLiteral(")</h1>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\LuisMauricio\Desktop\PM - PRACTICA - Mauricio Falla\PM - PRACTICA - Mauricio Falla\Views\Home\Index.cshtml"
 foreach (var producto in Model)
{

#line default
#line hidden
            BeginContext(154, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(162, 15, false);
#line 7 "C:\Users\LuisMauricio\Desktop\PM - PRACTICA - Mauricio Falla\PM - PRACTICA - Mauricio Falla\Views\Home\Index.cshtml"
  Write(producto.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(177, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(191, 15, false);
#line 8 "C:\Users\LuisMauricio\Desktop\PM - PRACTICA - Mauricio Falla\PM - PRACTICA - Mauricio Falla\Views\Home\Index.cshtml"
  Write(producto.Precio);

#line default
#line hidden
            EndContext();
            BeginContext(206, 32, true);
            WriteLiteral("</p>\r\n    <p>Esta en promocion: ");
            EndContext();
            BeginContext(239, 19, false);
#line 9 "C:\Users\LuisMauricio\Desktop\PM - PRACTICA - Mauricio Falla\PM - PRACTICA - Mauricio Falla\Views\Home\Index.cshtml"
                     Write(producto.enPromocio);

#line default
#line hidden
            EndContext();
            BeginContext(258, 14, true);
            WriteLiteral("</p>\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 272, "\"", 292, 1);
#line 10 "C:\Users\LuisMauricio\Desktop\PM - PRACTICA - Mauricio Falla\PM - PRACTICA - Mauricio Falla\Views\Home\Index.cshtml"
WriteAttributeValue("", 278, producto.Foto, 278, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(293, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 11 "C:\Users\LuisMauricio\Desktop\PM - PRACTICA - Mauricio Falla\PM - PRACTICA - Mauricio Falla\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PM___PRACTICA___Mauricio_Falla.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
