#pragma checksum "C:\Users\johns\OneDrive\Documentos\Proyectos C#\KimaliVic\Pages\ReservaEvento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79fc55bedc6ba108b654507442930124df0784e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KimaliVic.Pages.Pages_ReservaEvento), @"mvc.1.0.razor-page", @"/Pages/ReservaEvento.cshtml")]
namespace KimaliVic.Pages
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
#line 1 "C:\Users\johns\OneDrive\Documentos\Proyectos C#\KimaliVic\Pages\_ViewImports.cshtml"
using KimaliVic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79fc55bedc6ba108b654507442930124df0784e0", @"/Pages/ReservaEvento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54b389b8e9507a25b78ea34fdcfb513906c35ed4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ReservaEvento : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("template-contactform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("template-contactform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section id=""content"">
    <div class=""content-wrap"">
        <div class=""container clearfix"">

            <div class=""row"">

                <!-- Portfolio Single Image
                ============================================= -->
                <div class=""col-lg-8 portfolio-single-image"">
                    <a href=""#""><img");
            BeginWriteAttribute("src", " src=\"", 403, "\"", 441, 2);
            WriteAttributeValue("", 409, "images/salones/", 409, 15, true);
#nullable restore
#line 15 "C:\Users\johns\OneDrive\Documentos\Proyectos C#\KimaliVic\Pages\ReservaEvento.cshtml"
WriteAttributeValue("", 424, Model.NombreFoto, 424, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height:400px\" alt=\"Image\"></a>\r\n                    <h2>");
#nullable restore
#line 16 "C:\Users\johns\OneDrive\Documentos\Proyectos C#\KimaliVic\Pages\ReservaEvento.cshtml"
                   Write(Model.NombreSalon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <p style=""color: #00635c;"">Informaci??n de sal??n</p>
                </div><!-- .portfolio-single-image end -->
                <!-- Portfolio Single Content
                ============================================= -->
                <div class=""col-lg-4 portfolio-single-content"">

                    <!-- Portfolio Single - Description
                    ============================================= -->
                    <div class=""form-widget"">

                        <div class=""form-result""></div>

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79fc55bedc6ba108b654507442930124df0784e06113", async() => {
                WriteLiteral(@"

                            <div class=""form-process"">
                                <div class=""css3-spinner"">
                                    <div class=""css3-spinner-scaler""></div>
                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""col-12 form-group"">
                                    <label style=""color: #00635c;"" for=""template-contactform-name"">Nombre</label>
                                    <input type=""text"" id=""template-contactform-name"" name=""template-contactform-name""");
                BeginWriteAttribute("value", " value=\"", 1816, "\"", 1824, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sm-form-control required"" />
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-12 form-group"">
                                    <label style=""color: #00635c;"" for=""template-contactform-email"">Email</label>
                                    <input type=""text"" id=""template-contactform-email"" name=""template-contactform-email""");
                BeginWriteAttribute("value", " value=\"", 2286, "\"", 2294, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""required email sm-form-control"" />
                                </div>
                            </div>
                            <div class=""row"">

                                <div class=""col-6 form-group"">
                                    <label style=""color: #00635c;"" for=""template-contactform-checkin"">Fecha</label>
                                    <input type=""text"" id=""template-contactform-checkin"" name=""template-contactform-checkin""");
                BeginWriteAttribute("value", " value=\"", 2769, "\"", 2777, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""required sm-form-control datetimepicker"" />
                                </div>
                                <div class=""col-6 form-group"">
                                    <label style=""color: #00635c;"" for=""template-contactform-personas"">Personas</label>
                                    <input type=""text"" id=""template-contactform-personas"" name=""template-contactform-personas""");
                BeginWriteAttribute("value", " value=\"", 3182, "\"", 3190, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sm-form-control required"" />
                                </div>

                                </div>
                                <div class=""row"">
                                    <div class=""col-12 form-group"">
                                        <label style=""color: #00635c;"" for=""template-contactform-telefono"">Tel??fono</label>
                                        <input type=""text"" id=""template-contactform-telefono"" name=""template-contactform-telefono""");
                BeginWriteAttribute("value", " value=\"", 3686, "\"", 3694, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sm-form-control required"" />
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-12 form-group"">
                                        <label style=""color: #00635c;"" for=""template-contactform-ocasion"">Ocasi??n</label>
                                        <input type=""text"" id=""template-contactform-ocasion"" name=""template-contactform-ocasion""");
                BeginWriteAttribute("value", " value=\"", 4188, "\"", 4196, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""sm-form-control required"" />
                                    </div>
                                </div>
                                <div class=""row"">


                                    <div class=""w-100""></div>

                                    <div class=""col-4 form-group"">
                                        <button class=""btn btn-light"" style=""background-color: #00635c; color:white;"" type=""submit"" id=""template-contactform-submit"" name=""template-contactform-submit"" value=""submit"">RESERVAR</button>
                                    </div>
                                </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"line\"></div>\r\n                </div><!-- .portfolio-single-content end -->\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section><!-- #content end -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KimaliVic.Pages.ReservaEventoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KimaliVic.Pages.ReservaEventoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KimaliVic.Pages.ReservaEventoModel>)PageContext?.ViewData;
        public KimaliVic.Pages.ReservaEventoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
