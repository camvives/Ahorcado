#pragma checksum "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b4dd38ecbcf77c889d177ad579bc12f3052859"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UI.Web.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace UI.Web.Pages
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
#line 1 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\_ViewImports.cshtml"
using UI.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
using Ahorcado.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b4dd38ecbcf77c889d177ad579bc12f3052859", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"255be2d45b040e6ebe40c0515651a271bf3f15ef", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3 mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
  
    ViewData["Title"] = "Ahorcado";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
   PartidaAhorcado partida = HttpContext.Session.GetObjectFromJson<PartidaAhorcado>("Partida");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4 mb-3\">Ahorcado</h1>\r\n    <div class=\"row\">\r\n        <div class=\"column mr-5\">\r\n");
#nullable restore
#line 14 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
             if (partida.Intentos == 7)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img id=\"imagen\" src=\"./assets/0.png\">\r\n");
#nullable restore
#line 17 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
            }
            else if (partida.Intentos == 6)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img id=\"imagen\" src=\"./assets/1.png\">\r\n");
#nullable restore
#line 21 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
            }
            else if (partida.Intentos == 5)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img id=\"imagen\" src=\"./assets/2.png\">\r\n");
#nullable restore
#line 25 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
            }
            else if (partida.Intentos == 4)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img id=\"imagen\" src=\"./assets/3.png\">\r\n");
#nullable restore
#line 29 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
            }
            else if (partida.Intentos == 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img id=\"imagen\" src=\"./assets/4.png\">\r\n");
#nullable restore
#line 33 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
            }
            else if (partida.Intentos == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img id=\"imagen\" src=\"./assets/5.png\">\r\n");
#nullable restore
#line 37 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
            }
            else if (partida.Intentos == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img id=\"imagen\" src=\"./assets/6.png\">\r\n");
#nullable restore
#line 41 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
            }
            else if (partida.Intentos == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img id=\"imagen\" src=\"./assets/7.png\">\r\n");
#nullable restore
#line 45 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 47 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
         if (partida.Intentos > 0)
        {
            if (partida.Estado == PartidaAhorcado.Estados.Ganada)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"column col-lg-7\">\r\n                    <h2 class=\"mt-5\">¡Ganaste!</h2>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b4dd38ecbcf77c889d177ad579bc12f30528597953", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-primary mb-2 mt-3 block\">Volver a Jugar</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 57 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"column col-lg-7\">\r\n                    <h3 class=\"mt-4 mb-3\">Palabra a adivinar</h3>\r\n");
#nullable restore
#line 62 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
                     foreach (char l in partida.PalabraAAdivinar)
                    {
                        if (partida.LetrasAcertadas.Contains(l.ToString()))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"d-inline p-2 bg-dark text-white\">");
#nullable restore
#line 66 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
                                                                    Write(l);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 67 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"d-inline p-2 bg-dark text-white\">_</div>\r\n");
#nullable restore
#line 71 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h3 class=\"mt-5 mb-3\">Letras Acertadas</h3>\r\n");
#nullable restore
#line 75 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
                     if (partida.LetrasAcertadas.Any())
                    {
                        foreach (string l in partida.LetrasAcertadas)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"d-inline p-2 bg-info text-white\">");
#nullable restore
#line 79 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
                                                                    Write(l);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 80 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <h3 class=\"mt-5 mb-3\">Letras incorrectas</h3>\r\n");
#nullable restore
#line 84 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
                     if (partida.LetrasIncorrectas.Any())
                    {
                        foreach (string l in partida.LetrasIncorrectas)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"d-inline p-2 bg-danger text-white\">");
#nullable restore
#line 88 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
                                                                      Write(l);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 89 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"position-absolute bottom-50 end-50\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b4dd38ecbcf77c889d177ad579bc12f305285913290", async() => {
                WriteLiteral(@"
                            <div class=""col-auto"">
                                <label for=""letter"" class=""visually-hidden"">Ingrese una letra:</label>
                            </div>
                            <div class=""col-auto"">
                                <input name=""LetraIngresada"" type=""text"" class=""form-control"" id=""inputletter""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3784, "\"", 3798, 0);
                EndWriteAttribute();
                WriteLiteral(@" maxlength=""1"" required>
                            </div>
                            <div class=""col-auto"">
                                <button type=""submit"" class=""btn btn-primary mb-2"">Intentar</button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 107 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"column col-lg-7\">\r\n                <h2 class=\"mt-5\">Perdiste :(</h2>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25b4dd38ecbcf77c889d177ad579bc12f305285916025", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-primary mb-2 mt-3 block\">Volver a intentar</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 117 "C:\Users\camvi\Desktop\Ahorcado\UI.Web\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n       \r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
