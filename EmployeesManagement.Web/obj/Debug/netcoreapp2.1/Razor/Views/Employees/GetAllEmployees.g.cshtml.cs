#pragma checksum "C:\Users\Steve\Desktop\Local_Disc(D)\Programirane\STPInformationTechnology\EmployeesManagement\EmployeesManagement.Web\Views\Employees\GetAllEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8a97b5434872a0c0b1aaae8cef2c8fa5972d9ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_GetAllEmployees), @"mvc.1.0.view", @"/Views/Employees/GetAllEmployees.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/GetAllEmployees.cshtml", typeof(AspNetCore.Views_Employees_GetAllEmployees))]
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
#line 1 "C:\Users\Steve\Desktop\Local_Disc(D)\Programirane\STPInformationTechnology\EmployeesManagement\EmployeesManagement.Web\Views\_ViewImports.cshtml"
using EmployeesManagement.Web;

#line default
#line hidden
#line 2 "C:\Users\Steve\Desktop\Local_Disc(D)\Programirane\STPInformationTechnology\EmployeesManagement\EmployeesManagement.Web\Views\_ViewImports.cshtml"
using EmployeesManagement.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\Steve\Desktop\Local_Disc(D)\Programirane\STPInformationTechnology\EmployeesManagement\EmployeesManagement.Web\Views\_ViewImports.cshtml"
using EmployeesManagement.Common.BindingModels;

#line default
#line hidden
#line 4 "C:\Users\Steve\Desktop\Local_Disc(D)\Programirane\STPInformationTechnology\EmployeesManagement\EmployeesManagement.Web\Views\_ViewImports.cshtml"
using EmployeesManagement.Common.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Steve\Desktop\Local_Disc(D)\Programirane\STPInformationTechnology\EmployeesManagement\EmployeesManagement.Web\Views\_ViewImports.cshtml"
using EmployeesManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8a97b5434872a0c0b1aaae8cef2c8fa5972d9ce", @"/Views/Employees/GetAllEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ad58ee5ceaadecdb211de18f67e0659b8f8edc", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_GetAllEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeConciseViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Steve\Desktop\Local_Disc(D)\Programirane\STPInformationTechnology\EmployeesManagement\EmployeesManagement.Web\Views\Employees\GetAllEmployees.cshtml"
  
    ViewData["Title"] = "GetAllEmployees";

#line default
#line hidden
            BeginContext(90, 36, true);
            WriteLiteral("\r\n<h2 style=\"text-align:center\">All ");
            EndContext();
            BeginContext(127, 24, false);
#line 6 "C:\Users\Steve\Desktop\Local_Disc(D)\Programirane\STPInformationTechnology\EmployeesManagement\EmployeesManagement.Web\Views\Employees\GetAllEmployees.cshtml"
                             Write(this.ViewData["Company"]);

#line default
#line hidden
            EndContext();
            BeginContext(151, 362, true);
            WriteLiteral(@" Employees</h2>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th colspan=""3"" style=""text-align:center; background-color:#cccccc"">Employees</th>
        </tr>
        <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Experience Level</th>
        </tr>
    </thead>
    <tbody>
        ");
            EndContext();
            BeginContext(514, 22, false);
#line 20 "C:\Users\Steve\Desktop\Local_Disc(D)\Programirane\STPInformationTechnology\EmployeesManagement\EmployeesManagement.Web\Views\Employees\GetAllEmployees.cshtml"
   Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(536, 24, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeConciseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
