#pragma checksum "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76cef7a6edc75e4a01338c4c1f8330269124a4d3"
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
#line 1 "C:\Users\LNSP\Desktop\projeto\eventos\Views\_ViewImports.cshtml"
using eventos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LNSP\Desktop\projeto\eventos\Views\_ViewImports.cshtml"
using eventos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76cef7a6edc75e4a01338c4c1f8330269124a4d3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2837d7db2d5a95b0b03378b374e230adb7e5fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eventos.Models.Evento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/compra.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style type=""text/css"">
    .botao{
	background: #3F51B5;
	color: #fff;
	border: 2px solid black;
    height: 54px;
    width: 101px;
	}
	.botao:hover{
	cursor: pointer;
	background: black;
	}
    .titulos{ text-align: center;background-color: #343a40 ; color: white;}

    .botao1{
	background: #B00000;
	color: #fff;
	border: 2px solid black;
    height: 54px;
    width: 101px;
	}
	.botao1:hover{
	cursor: pointer;
	background: black;
	}
</style>
<div class=""container-fluid"" style=""margin-top: 10px; text-align: center; "">      
<h2 class=""titulos"" style=""text-align: center; margin-bottom: 50px;"">Proximos Eventos</h2>
");
#nullable restore
#line 34 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
     foreach(var evento in  Model){
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 35rem;margin-bottom: 26px;float:left; margin-left: 179px; border:4px solid; margin-top: 10px;\">\n    <img class=\"card-img-top\" style=\"height: 293px;\"");
            BeginWriteAttribute("src", " src=", 926, "", 945, 1);
#nullable restore
#line 37 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
WriteAttributeValue("", 931, evento.imagem, 931, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\n    <div class=\"card-body\">\n        <h5 class=\"card-title\">");
#nullable restore
#line 39 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
                          Write(evento.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <h5 class=\"card-title\">");
#nullable restore
#line 40 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
                          Write(evento.Data.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <h5 class=\"card-title\">");
#nullable restore
#line 41 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
                          Write(evento.capacidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Ingressos disponiveis</h5>\n        <h5 class=\"card-title\"><strong></strong>");
#nullable restore
#line 42 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
                                           Write(evento.ValorIngresso.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <p class=\"card-text\">Veja seu Idolo no ");
#nullable restore
#line 43 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
                                          Write(evento.Casa.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        \n");
#nullable restore
#line 45 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
         if(@evento.capacidade > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 1414, "\"", 1453, 2);
            WriteAttributeValue("", 1421, "/Gestao/ComprarEvento/", 1421, 22, true);
#nullable restore
#line 46 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
WriteAttributeValue("", 1443, evento.Id, 1443, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"ComprarID\"><input type=\"submit\" value=\"Comprar\" class=\"botao\"></a>\n");
#nullable restore
#line 47 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("          <a><input type=\"submit\" value=\"Esgotado\" class=\"botao1\"></a>\n");
#nullable restore
#line 49 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n        \n    </div>\n");
#nullable restore
#line 53 "C:\Users\LNSP\Desktop\projeto\eventos\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76cef7a6edc75e4a01338c4c1f8330269124a4d37882", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eventos.Models.Evento>> Html { get; private set; }
    }
}
#pragma warning restore 1591