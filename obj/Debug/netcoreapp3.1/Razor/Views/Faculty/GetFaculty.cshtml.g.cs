#pragma checksum "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f20080d17631d4f03cda500714a8299573edc858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faculty_GetFaculty), @"mvc.1.0.view", @"/Views/Faculty/GetFaculty.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20080d17631d4f03cda500714a8299573edc858", @"/Views/Faculty/GetFaculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Faculty_GetFaculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.FacultyViewModel>
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
            WriteLiteral("\r\n\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n\t<style>\r\n        h2 {\r\n            color: #ff7f50;\r\n        }\r\n\t</style>\r\n");
            }
            );
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 12 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
 for (var i = 0; i < Model.Faculty.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 320, "", 362, 1);
#nullable restore
#line 18 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
WriteAttributeValue("", 324, String.Concat("myDiv:", i.ToString()), 324, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 407, "\"", 440, 1);
#nullable restore
#line 19 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
WriteAttributeValue("", 413, Model.Faculty[i].imagePath, 413, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;width:190px\"");
            BeginWriteAttribute("alt", " alt=\"", 474, "\"", 480, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 950, "", 992, 1);
#nullable restore
#line 38 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
WriteAttributeValue("", 954, String.Concat("myDiv:", i.ToString()), 954, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1037, "\"", 1070, 1);
#nullable restore
#line 39 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
WriteAttributeValue("", 1043, Model.Faculty[i].imagePath, 1043, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;width:190px\"");
            BeginWriteAttribute("alt", " alt=\"", 1104, "\"", 1110, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 47 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 1580, "", 1622, 1);
#nullable restore
#line 58 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
WriteAttributeValue("", 1584, String.Concat("myDiv:", i.ToString()), 1584, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1667, "\"", 1700, 1);
#nullable restore
#line 59 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
WriteAttributeValue("", 1673, Model.Faculty[i].imagePath, 1673, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;width:190px\"");
            BeginWriteAttribute("alt", " alt=\"", 1734, "\"", 1740, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 63 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 2210, "", 2252, 1);
#nullable restore
#line 78 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
WriteAttributeValue("", 2214, String.Concat("myDiv:", i.ToString()), 2214, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2297, "\"", 2330, 1);
#nullable restore
#line 79 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
WriteAttributeValue("", 2303, Model.Faculty[i].imagePath, 2303, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;width:190px\"");
            BeginWriteAttribute("alt", " alt=\"", 2364, "\"", 2370, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 83 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n        <div>&nbsp;</div>\r\n        <div>&nbsp;</div>\r\n    </div>\r\n");
#nullable restore
#line 90 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"dialog\"></div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20080d17631d4f03cda500714a8299573edc85814011", async() => {
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
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f20080d17631d4f03cda500714a8299573edc85815109", async() => {
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
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f20080d17631d4f03cda500714a8299573edc85816287", async() => {
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
                WriteLiteral("\r\n    <script>\r\n\t\tvar $j = jQuery.noConflict();\r\n\t\tvar facultyData = ");
#nullable restore
#line 99 "C:\Users\archi\Desktop\ISTE Client\Project3_Details_And_Views\Project3EnahncedCode\Project3_FinalExam\Views\Faculty\GetFaculty.cshtml"
                     Write(Html.Raw(Json.Serialize(Model.Faculty)));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n");
                WriteLiteral(@"		function getName(id) {
			console.log(facultyData);
			let facultyElement = (id).split(':')[1];

			var divContent = ""<div><ul>"";

			divContent += ""<li><font color='#18ADEA'><b><u>Title:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].title + ""</b></<li>""
			divContent += ""<li><font color='#18ADEA'><b><u>Email:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].email + ""</b></<li>""
            divContent += ""<li><font color='#18ADEA'><b><u>Office:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].office + ""</b></<li>"";

            divContent += ""<li><font color='#18ADEA'><b><u>Research:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].office + ""</b></<li>"";

			divContent += ""</ul></div>"";

			console.log(divContent);

			let elmnt = document.getElementById(id);
			$j(""#dialog"").html(divContent);
			$j(""#dialog"").dialog({
				title: facultyData[facultyElement].name,
				wid");
                WriteLiteral("th: 500,\r\n\t\t\t\tposition: { my: \"center\", at: \"bottom+40%\", of: elmnt}\r\n\t\t\t});\r\n\t\t\t$j(\"#dialog\").dialog(\"open\")\r\n\t\t}\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.FacultyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
