#pragma checksum "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0465d6f854aa52a59b35b655ffe7e3a219b0d2b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Minor_GetMinors), @"mvc.1.0.view", @"/Views/Minor/GetMinors.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0465d6f854aa52a59b35b655ffe7e3a219b0d2b0", @"/Views/Minor/GetMinors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Minor_GetMinors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.MinorsViewModel>
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
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    <style>\r\n        h2 {\r\n            color: #ff7f50;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("<h2>");
#nullable restore
#line 9 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div id=\"myDegrees\" class=\"myDegrees\"></div>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
 foreach (var minor in Model.Minors)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 276, "\"", 320, 1);
#nullable restore
#line 15 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
WriteAttributeValue("", 281, String.Concat("myDegrees", minor.name), 281, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"myDegrees\"></div>\r\n    <h3");
            BeginWriteAttribute("id", " id=", 355, "", 395, 1);
#nullable restore
#line 16 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
WriteAttributeValue("", 359, String.Concat("myHdng", minor.name), 359, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 16 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
                                              Write(minor.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n    <ul");
            BeginWriteAttribute("id", " id=", 429, "", 467, 1);
#nullable restore
#line 17 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
WriteAttributeValue("", 433, String.Concat("myul", minor.name), 433, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <li><a");
            BeginWriteAttribute("href", " href=", 484, "", 527, 1);
#nullable restore
#line 18 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
WriteAttributeValue("", 490, String.Concat("#myDesc", minor.name), 490, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Description</a></li>\r\n        <li><a");
            BeginWriteAttribute("href", " href=", 564, "", 607, 1);
#nullable restore
#line 19 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
WriteAttributeValue("", 570, String.Concat("#myCour", minor.name), 570, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Courses</a></li>\r\n    </ul>\r\n    <div");
            BeginWriteAttribute("id", " id=", 645, "", 684, 1);
#nullable restore
#line 21 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
WriteAttributeValue("", 649, String.Concat("myDiv", minor.name), 649, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <p");
            BeginWriteAttribute("id", " id=", 697, "", 737, 1);
#nullable restore
#line 22 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
WriteAttributeValue("", 701, String.Concat("myPara", minor.name), 701, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
                                              Write(minor.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <div");
            BeginWriteAttribute("id", " id=", 770, "", 810, 1);
#nullable restore
#line 24 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
WriteAttributeValue("", 774, String.Concat("myDesc", minor.name), 774, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <p>");
#nullable restore
#line 25 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
          Write(minor.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div");
            BeginWriteAttribute("id", " id=", 880, "", 920, 1);
#nullable restore
#line 27 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
WriteAttributeValue("", 884, String.Concat("myCour", minor.name), 884, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <ul>\r\n");
#nullable restore
#line 29 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
                 foreach (var conc in minor.courses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 31 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
                   Write(conc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 32 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 39 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
                
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0465d6f854aa52a59b35b655ffe7e3a219b0d2b011900", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0465d6f854aa52a59b35b655ffe7e3a219b0d2b013000", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0465d6f854aa52a59b35b655ffe7e3a219b0d2b014180", async() => {
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
                WriteLiteral("\r\n    <script>\r\n                // Create JqueryUi Tab\r\n        var minorData = ");
#nullable restore
#line 48 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Minor\GetMinors.cshtml"
                   Write(Html.Raw(Json.Serialize(Model.Minors)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                let headings = document.querySelectorAll(\"h3\");//ul\r\n               let list = document.querySelectorAll(\"[id^=\'myul\']\");//ul\r\n");
                WriteLiteral(@"
                let divs = document.querySelectorAll(""[id^='myDiv']"");


                for (var i = 0; i < headings.length; i++) {
                    $(""#myDegrees"" + minorData[i].name).append($(""#"" + headings[i].id));
                    $(""#myDegrees"" + minorData[i].name).append($(""#"" + list[i].id));

");
                WriteLiteral(@"                    $(""#myDegrees"" + minorData[i].name).append($(""#"" + divs[i].id));
                }

                $('.myDegrees').tabs({

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.MinorsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
