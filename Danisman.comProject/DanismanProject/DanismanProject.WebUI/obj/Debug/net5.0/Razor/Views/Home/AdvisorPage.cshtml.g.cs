#pragma checksum "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "583fece61048ea8ed9fa22f8af5db5e19e524805"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdvisorPage), @"mvc.1.0.view", @"/Views/Home/AdvisorPage.cshtml")]
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
#line 1 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\_ViewImports.cshtml"
using DanismanProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\_ViewImports.cshtml"
using DanismanProject.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\_ViewImports.cshtml"
using DanismanProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\_ViewImports.cshtml"
using DanismanProject.WebUI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\_ViewImports.cshtml"
using DanismanProject.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583fece61048ea8ed9fa22f8af5db5e19e524805", @"/Views/Home/AdvisorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0182077dd178c6e0b02d16efb7673dc389398c30", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdvisorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Advisor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/null.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row mx-3 mt-4\">\r\n        <div class=\"col-md-3\">\r\n            <div class=\"d-flex flex-column justify-content-center w-50 mx-auto\">\r\n");
#nullable restore
#line 7 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"
                 if (Model.AdvisorImg == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "583fece61048ea8ed9fa22f8af5db5e19e5248055361", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "583fece61048ea8ed9fa22f8af5db5e19e5248056759", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 445, "~/img/", 445, 6, true);
#nullable restore
#line 13 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"
AddHtmlAttributeValue("", 451, Model.AdvisorImg, 451, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"text-center mt-2\">\r\n");
#nullable restore
#line 17 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"
                     if (@Model.IsSuitable)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"d-inline\">Uygun  </p><i class=\"fa-solid fa-circle-check text-success\"></i>\r\n");
#nullable restore
#line 20 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Uygun Değil </p><i class=\"fa-solid fa-circle-xmark text-danger\"></i>\r\n");
#nullable restore
#line 24 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"text-center \"> <span class=\"fs-5 fw-bold success-rate\">%");
#nullable restore
#line 26 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"
                                                                               Write(Model.SuccessRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> Başarı</div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"d-flex justify-content-start flex-column py-2\">\r\n                <div class=\"fs-3\">\r\n\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"
                 if (Model.Job != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"fs-2 fw-bold  mt-3\" style=\"color: #48dbfb;\">");
#nullable restore
#line 36 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"
                                                                       Write(Model.Job.JobName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 37 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"fs-3  text-dark mt-2\">");
#nullable restore
#line 39 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"
                                             Write(Model.AdvisorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

                
            </div>
            <hr class=""w-50""/>
            <a class=""btn btn-lg "" >Danış</a>
        </div>
    </div>
    <div class=""m-5 px-2"">
        <div class=""mx-5 mt-5 px-2 fs-2 fw-bold"" style=""color: #7f8c8d; ""><p>Hakkımda</p></div>
        <div class=""mx-5 my-5 mt-2 px-2""> ");
#nullable restore
#line 49 "C:\Users\MONSTER\Desktop\DanismanProject\DanismanProject.WebUI\Views\Home\AdvisorPage.cshtml"
                                     Write(Model.AdvisorAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n       \r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Advisor> Html { get; private set; }
    }
}
#pragma warning restore 1591
