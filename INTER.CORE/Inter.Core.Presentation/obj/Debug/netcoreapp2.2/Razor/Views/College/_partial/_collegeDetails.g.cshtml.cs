#pragma checksum "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1266c2cb135463dae2dd569da773091e9c22b8c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_College__partial__collegeDetails), @"mvc.1.0.view", @"/Views/College/_partial/_collegeDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/College/_partial/_collegeDetails.cshtml", typeof(AspNetCore.Views_College__partial__collegeDetails))]
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
#line 2 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
using Inter.Core.App.Enumerables;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1266c2cb135463dae2dd569da773091e9c22b8c7", @"/Views/College/_partial/_collegeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aa144cf08474a888711b6b07829c8fe2d17ee19", @"/Views/_ViewImports.cshtml")]
    public class Views_College__partial__collegeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inter.Core.App.ViewModel.CollegeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 189, true);
            WriteLiteral("\r\n<div class=\"col-lg-6\">\r\n    <!-- Circle Buttons -->\r\n    <div class=\"card shadow mb-4\">\r\n        <div class=\"card-header py-3\">\r\n            <h6 class=\"m-0 font-weight-bold text-primary\">");
            EndContext();
            BeginContext(275, 10, false);
#line 8 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
                                                     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(285, 900, true);
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
                            <a href=""#"" class=""dropdown-item"" data-toggle=""modal"" data-target=""#modalinsertTimeCollege"">+ Add College Time</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1185, "\"", 1245, 1);
#line 21 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
WriteAttributeValue("", 1192, Url.Action("Edit", "College", new { id = Model.Id }), 1192, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1246, 255, true);
            WriteLiteral(">Edit</a>\r\n                        </div>\r\n                    </li>\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1502, 43, false);
#line 32 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1545, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1630, 39, false);
#line 35 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1754, 40, false);
#line 38 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1794, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1879, 36, false);
#line 41 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2000, 43, false);
#line 44 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2128, 39, false);
#line 47 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2167, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2252, 47, false);
#line 50 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.ContactName));

#line default
#line hidden
            EndContext();
            BeginContext(2299, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2384, 43, false);
#line 53 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayFor(model => model.ContactName));

#line default
#line hidden
            EndContext();
            BeginContext(2427, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2512, 47, false);
#line 56 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2559, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2644, 43, false);
#line 59 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2687, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2772, 41, false);
#line 62 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2813, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2898, 37, false);
#line 65 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2935, 78, true);
            WriteLiteral("\r\n                </dd>\r\n\r\n            </dl>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
            EndContext();
#line 73 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
     foreach (var time in Model.CollegeTimeViewModel)
    {

#line default
#line hidden
            BeginContext(3075, 146, true);
            WriteLiteral("        <div class=\"card shadow mb-4\">\r\n            <div class=\"card-header py-3\">\r\n                <h6 class=\"m-0 font-weight-bold text-primary\">");
            EndContext();
            BeginContext(3222, 11, false);
#line 77 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
                                                         Write(time.Period);

#line default
#line hidden
            EndContext();
            BeginContext(3233, 108, true);
            WriteLiteral("</h6>\r\n            </div>\r\n\r\n            <div class=\"card-body\">\r\n\r\n                <div class=\"small mb-1\">");
            EndContext();
            BeginContext(3342, 10, false);
#line 82 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3352, 630, true);
            WriteLiteral(@"</div>
                <nav class=""navbar navbar-expand navbar-light bg-light mb-4"">
                    <ul class=""navbar-nav ml-auto"">
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Actions
                            </a>
                            <div class=""dropdown-menu dropdown-menu-right animated--grow-in"" aria-labelledby=""navbarDropdown"">
                                <a class=""dropdown-item""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3982, "\"", 4033, 3);
            WriteAttributeValue("", 3989, "javascript:college.editCollegeTime(", 3989, 35, true);
#line 90 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
WriteAttributeValue("", 4024, time.Id, 4024, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4032, ")", 4032, 1, true);
            EndWriteAttribute();
            BeginContext(4034, 683, true);
            WriteLiteral(@">Edit</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Delete</a>
                            </div>
                        </li>
                    </ul>
                </nav>

                <p>Use Font Awesome Icons (included with this theme package) along with the circle buttons as shown in the examples below!</p>
                <!-- Circle Buttons (Default) -->

                <dl class=""row"">
                    <dt class=""col-sm-6"">
                        Start Time
                    </dt>
                    <dd class=""col-sm-6"">
                        ");
            EndContext();
            BeginContext(4718, 31, false);
#line 106 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
                   Write(time.StartTime.ToString("H:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(4749, 203, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-6\">\r\n                        Finish Time\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
            EndContext();
            BeginContext(4953, 32, false);
#line 112 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
                   Write(time.FinishTime.ToString("H:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(4985, 205, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-6\">\r\n                        Time for Week\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
            EndContext();
            BeginContext(5191, 16, false);
#line 118 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
                   Write(time.TimeForWeek);

#line default
#line hidden
            EndContext();
            BeginContext(5207, 202, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-6\">\r\n                        Book Price\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
            EndContext();
            BeginContext(5410, 14, false);
#line 124 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
                   Write(time.BookPrice);

#line default
#line hidden
            EndContext();
            BeginContext(5424, 202, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-6\">\r\n                        Exam Price\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
            EndContext();
            BeginContext(5627, 14, false);
#line 130 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
                   Write(time.ExamPrice);

#line default
#line hidden
            EndContext();
            BeginContext(5641, 207, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-6\">\r\n                        Insurance Price\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
            EndContext();
            BeginContext(5849, 19, false);
#line 136 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
                   Write(time.InsurancePrice);

#line default
#line hidden
            EndContext();
            BeginContext(5868, 203, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-6\">\r\n                        Total Price\r\n                    </dt>\r\n                    <dd class=\"col-sm-6\">\r\n                        ");
            EndContext();
            BeginContext(6072, 15, false);
#line 142 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
                   Write(time.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(6087, 90, true);
            WriteLiteral("\r\n                    </dd>\r\n\r\n                </dl>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 148 "C:\Users\Caio's PC\Documents\Repositories\MarketInter.CORE\INTER.CORE\Inter.Core.Presentation\Views\College\_partial\_collegeDetails.cshtml"
    }

#line default
#line hidden
            BeginContext(6184, 128, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"modal fade\" id=\"div-modal-edit-college-time\" tabindex=\"-1\" role=\"dialog\" aria-hidden=\"true\">\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inter.Core.App.ViewModel.CollegeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
