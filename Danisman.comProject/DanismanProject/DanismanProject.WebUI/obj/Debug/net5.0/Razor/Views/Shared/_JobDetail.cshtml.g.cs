#pragma checksum "C:\Users\MONSTER\Desktop\KURS\DanismanSite\DanismanSite_Backend\DanismanProject\DanismanProject.WebUI\Views\Shared\_JobDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3c1ffb70d1ee2ce27eaa072c61a4acd64b72ac7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__JobDetail), @"mvc.1.0.view", @"/Views/Shared/_JobDetail.cshtml")]
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
#line 1 "C:\Users\MONSTER\Desktop\KURS\DanismanSite\DanismanSite_Backend\DanismanProject\DanismanProject.WebUI\Views\_ViewImports.cshtml"
using DanismanProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MONSTER\Desktop\KURS\DanismanSite\DanismanSite_Backend\DanismanProject\DanismanProject.WebUI\Views\_ViewImports.cshtml"
using DanismanProject.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3c1ffb70d1ee2ce27eaa072c61a4acd64b72ac7", @"/Views/Shared/_JobDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d8c268e62733b53bad7de1e0d4d219910548cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__JobDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Advisor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"container-jobdetail-body\">\r\n        <div class=\"container-jobdetail\">\r\n            <div class=\"card\">\r\n                <div class=\"imgBx\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 198, "\"", 221, 1);
#nullable restore
#line 7 "C:\Users\MONSTER\Desktop\KURS\DanismanSite\DanismanSite_Backend\DanismanProject\DanismanProject.WebUI\Views\Shared\_JobDetail.cshtml"
WriteAttributeValue("", 204, Model.Job.JobImg, 204, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 222, "\"", 228, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"contentBx\">\r\n                    <div class=\"content\">\r\n                        <h2>");
#nullable restore
#line 11 "C:\Users\MONSTER\Desktop\KURS\DanismanSite\DanismanSite_Backend\DanismanProject\DanismanProject.WebUI\Views\Shared\_JobDetail.cshtml"
                       Write(Model.Job.JobName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>");
#nullable restore
#line 12 "C:\Users\MONSTER\Desktop\KURS\DanismanSite\DanismanSite_Backend\DanismanProject\DanismanProject.WebUI\Views\Shared\_JobDetail.cshtml"
                      Write(Model.Category.CategoryDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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