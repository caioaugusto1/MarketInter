#pragma checksum "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57463a5e8ba1675c3c63e0114b8644dfbf2200f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student__partial__details_delete), @"mvc.1.0.view", @"/Views/Student/_partial/_details_delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/_partial/_details_delete.cshtml", typeof(AspNetCore.Views_Student__partial__details_delete))]
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
#line 1 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\_ViewImports.cshtml"
using Inter.Core.Presentation;

#line default
#line hidden
#line 2 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\_ViewImports.cshtml"
using Inter.Core.Presentation.Models;

#line default
#line hidden
#line 3 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\_ViewImports.cshtml"
using Inter.Core.App.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57463a5e8ba1675c3c63e0114b8644dfbf2200f3", @"/Views/Student/_partial/_details_delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aa144cf08474a888711b6b07829c8fe2d17ee19", @"/Views/_ViewImports.cshtml")]
    public class Views_Student__partial__details_delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inter.Core.App.ViewModel.StudentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Util/Util.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Student/student.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(50, 189, true);
            WriteLiteral("\r\n<div class=\"col-lg-6\">\r\n    <!-- Circle Buttons -->\r\n    <div class=\"card shadow mb-4\">\r\n        <div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">");
            EndContext();
            BeginContext(240, 14, false);
#line 7 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
                                                     Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(254, 690, true);
            WriteLiteral(@"</h6>
        </div>
        <div class=""card-body"">
            <div class=""small mb-1""></div>
            <nav class=""navbar navbar-expand navbar-light bg-light mb-4"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Actions
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right animated--grow-in"" aria-labelledby=""navbarDropdown"">
                            <a class=""dropdown-item""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 944, "\"", 1004, 1);
#line 18 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
WriteAttributeValue("", 951, Url.Action("Edit", "Student", new { id = Model.Id }), 951, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1005, 129, true);
            WriteLiteral(">Edit</a>\r\n                            <div class=\"dropdown-divider\"></div>\r\n                            <a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1134, "\"", 1189, 3);
            WriteAttributeValue("", 1141, "javascript:student.popUpConfirmDelete(", 1141, 38, true);
#line 20 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
WriteAttributeValue("", 1179, Model.Id, 1179, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1188, ")", 1188, 1, true);
            EndWriteAttribute();
            BeginContext(1190, 257, true);
            WriteLiteral(@">Delete</a>
                        </div>
                    </li>
                </ul>
            </nav>
        </div>

        <div class=""card-body"">

            <dl class=""row"">
                <dt class=""col-sm-6"">
                    ");
            EndContext();
            BeginContext(1448, 50, false);
#line 31 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayNameFor(model => model.DateOfBirthday));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1583, 46, false);
#line 34 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayFor(model => model.DateOfBirthday));

#line default
#line hidden
            EndContext();
            BeginContext(1629, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1714, 51, false);
#line 37 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayNameFor(model => model.PassaportNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1850, 47, false);
#line 40 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayFor(model => model.PassaportNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1982, 43, false);
#line 43 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2110, 39, false);
#line 46 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2149, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2234, 41, false);
#line 49 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2275, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2360, 37, false);
#line 52 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2397, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2482, 48, false);
#line 55 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayNameFor(model => model.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2530, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2615, 44, false);
#line 58 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayFor(model => model.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2659, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2744, 47, false);
#line 61 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Nationality));

#line default
#line hidden
            EndContext();
            BeginContext(2791, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2876, 43, false);
#line 64 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayFor(model => model.Nationality));

#line default
#line hidden
            EndContext();
            BeginContext(2919, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(3004, 40, false);
#line 67 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(3044, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(3129, 36, false);
#line 70 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(3165, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(3250, 43, false);
#line 73 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(3293, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(3378, 39, false);
#line 76 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
               Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(3417, 84, true);
            WriteLiteral("\r\n                </dd>\r\n\r\n            </dl>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(3502, 70, false);
#line 84 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\Student\_partial\_details_delete.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_partial/_modalDelete.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(3572, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(3689, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57463a5e8ba1675c3c63e0114b8644dfbf2200f316004", async() => {
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
            EndContext();
            BeginContext(3730, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3732, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57463a5e8ba1675c3c63e0114b8644dfbf2200f317184", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inter.Core.App.ViewModel.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
