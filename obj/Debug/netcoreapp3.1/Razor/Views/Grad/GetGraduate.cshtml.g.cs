#pragma checksum "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1c2338c0337ec21489cb8a0b4c8b5202f94e3b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grad_GetGraduate), @"mvc.1.0.view", @"/Views/Grad/GetGraduate.cshtml")]
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
#line 1 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\_ViewImports.cshtml"
using Project3_FinalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\_ViewImports.cshtml"
using Project3_FinalExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1c2338c0337ec21489cb8a0b4c8b5202f94e3b2", @"/Views/Grad/GetGraduate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Grad_GetGraduate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.GradViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/themes/ui-lightness/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    <style>\r\n        h2 {\r\n            color: #ff7f50;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("<h2>");
#nullable restore
#line 10 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n\r\n<div id=\"myGradDegrees\"></div>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
 foreach (var grad in Model.Grads)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3");
            BeginWriteAttribute("id", " id=", 259, "", 304, 1);
#nullable restore
#line 18 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
WriteAttributeValue("", 263, String.Concat("myHdng", grad.degreeName), 263, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 18 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
                                               Write(grad.degreeName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n");
            WriteLiteral("<div");
            BeginWriteAttribute("id", " id=", 351, "", 395, 1);
#nullable restore
#line 20 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
WriteAttributeValue("", 355, String.Concat("myDiv", grad.degreeName), 355, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <p>");
#nullable restore
#line 21 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
  Write(grad.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 22 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
  Write(grad.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <ul>\r\n");
#nullable restore
#line 24 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
         if (grad.concentrations!=null) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
         foreach (var conc in @grad.concentrations)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 27 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
       Write(conc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 28 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n");
#nullable restore
#line 33 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Grad\GetGraduate.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c2338c0337ec21489cb8a0b4c8b5202f94e3b29163", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1c2338c0337ec21489cb8a0b4c8b5202f94e3b210262", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c2338c0337ec21489cb8a0b4c8b5202f94e3b211442", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        // Create Accordion
        let headings = document.querySelectorAll(""h3"");
        let divs = document.querySelectorAll(""[id^='myDiv']"");

        for (var i = 0; i < headings.length; i++) {
            $(""#myGradDegrees"").append($(""#"" + headings[i].id));
            $(""#myGradDegrees"").append($(""#"" + divs[i].id));
        }

        $('#myGradDegrees').accordion({
            collapsible: false,
            active: false,
            heightStyle: ""content""
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.GradViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591