#pragma checksum "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "385908bd802ebfc5c97d83737f38e503c106b305"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_College_Edit), @"mvc.1.0.view", @"/Views/College/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/College/Edit.cshtml", typeof(AspNetCore.Views_College_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"385908bd802ebfc5c97d83737f38e503c106b305", @"/Views/College/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aa144cf08474a888711b6b07829c8fe2d17ee19", @"/Views/_ViewImports.cshtml")]
    public class Views_College_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inter.Core.App.ViewModel.CollegeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-create-collegeTime"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Util/Util.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/College/college.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 66, false);
#line 3 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\Edit.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_partial/_topMenu.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(119, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(124, 74, false);
#line 5 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\Edit.cshtml"
Write(await Html.PartialAsync("~/Views/College/_partial/_collegeDetails.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(198, 590, true);
            WriteLiteral(@"

<div class=""modal fade"" id=""modalinsertTimeCollege"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Time College</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""modalCollegeTime"">
                ");
            EndContext();
            BeginContext(788, 251, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "385908bd802ebfc5c97d83737f38e503c106b3056399", async() => {
                BeginContext(823, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
                BeginContext(848, 84, false);
#line 19 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\Edit.cshtml"
               Write(await Html.PartialAsync("~/Views/College/_partial/_modal_create_timeCollege.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(932, 61, true);
                WriteLiteral("\r\n\r\n                    <input type=\"hidden\" name=\"CollegeId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 993, "\"", 1010, 1);
#line 21 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\Edit.cshtml"
WriteAttributeValue("", 1001, Model.Id, 1001, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1011, 21, true);
                WriteLiteral(" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1039, 453, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" onclick=""college.saveCollegeTime();"" class=""btn btn-primary"">Save</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""div-modal-edit-college-time"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">

</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1510, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1518, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "385908bd802ebfc5c97d83737f38e503c106b3059619", async() => {
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
                BeginContext(1559, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1565, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "385908bd802ebfc5c97d83737f38e503c106b30510874", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1612, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 41 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\Edit.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inter.Core.App.ViewModel.CollegeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
