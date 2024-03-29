#pragma checksum "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ad539a377b4b768656f411e7474953b38861272"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Grid), @"mvc.1.0.view", @"/Views/Employee/Grid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Grid.cshtml", typeof(AspNetCore.Views_Employee_Grid))]
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
#line 1 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\_ViewImports.cshtml"
using DotNetCore.Web;

#line default
#line hidden
#line 2 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\_ViewImports.cshtml"
using DotNetCore.Web.Models;

#line default
#line hidden
#line 1 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
using DotNetCore.Components;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad539a377b4b768656f411e7474953b38861272", @"/Views/Employee/Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10598856f6258f03fe623e81ec372034dd78e46b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetCore.DataLayer.Paging.IPaginate<DotNetCore.DomainModel.EmployeeModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
  
    Layout = null;
    string PageUrl = Url.Action("Grid", "Employee");

#line default
#line hidden
            BeginContext(196, 95, true);
            WriteLiteral("<div id=\"divGrid\">\r\n    <table class=\"table table-responsive\" data-sorting=\"true\" data-sortby=\"");
            EndContext();
            BeginContext(292, 12, false);
#line 8 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
                                                                      Write(Model.SortBy);

#line default
#line hidden
            EndContext();
            BeginContext(304, 22, true);
            WriteLiteral("\" data-sortdirection=\"");
            EndContext();
            BeginContext(327, 19, false);
#line 8 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
                                                                                                         Write(Model.SortDirection);

#line default
#line hidden
            EndContext();
            BeginContext(346, 519, true);
            WriteLiteral(@""">
        <thead>
            <tr>
                <th data-columnName=""FirstName"">First Name</th>
                <th data-columnName=""LastName"">Last Name</th>
                <th data-columnName=""FullName"">Full Name</th>
                <th data-columnName=""Code"">Code</th>
                <th data-columnName=""Department.Name"">Department Name</th>
                <th data-columnName=""Designation.Name"">Designation Name</th>
                <td></td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
             foreach (var item in Model.Items)
            {

#line default
#line hidden
            BeginContext(928, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(975, 44, false);
#line 24 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1051, 43, false);
#line 25 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1126, 43, false);
#line 26 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1201, 39, false);
#line 27 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1272, 50, false);
#line 28 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1354, 51, false);
#line 29 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Designation.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1463, 65, false);
#line 31 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", "Employee", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1557, 69, false);
#line 32 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", "Employee", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
            }

#line default
#line hidden
            BeginContext(1693, 182, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-xs-12 col-md-4 align-xs-center align-md-left margin-xs-bottom-10 margin-md-bottom-0\">\r\n        ");
            EndContext();
            BeginContext(1876, 59, false);
#line 45 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
   Write(Html.GridCountDetails(Model.Index, Model.Size, Model.Count));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 338, true);
            WriteLiteral(@"
    </div>
    <div class=""col-xs-12 col-md-4 align-xs-center align-md-center margin-xs-bottom-10 margin-md-bottom-0"">
        <div class=""form-group"">
            <label class=""col-xs-6 col-sm-6 col-md-6 align-right margin-top-5"">Page Size :</label>
            <div class=""col-xs-6 col-sm-3 col-md-6 align-left"">
                ");
            EndContext();
            BeginContext(2274, 57, false);
#line 51 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
           Write(Html.GridPageSize(Model.Size, "Employee/Grid", "divGrid"));

#line default
#line hidden
            EndContext();
            BeginContext(2331, 127, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-xs-12 col-md-4 align-xs-center align-md-right\">\r\n        ");
            EndContext();
            BeginContext(2459, 71, false);
#line 56 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
   Write(Html.Hidden("hfRecordCount", Model.Count, new { id = "hfRecordCount" }));

#line default
#line hidden
            EndContext();
            BeginContext(2530, 103, true);
            WriteLiteral("\r\n        <div class=\"dataTables_paginate paging_bootstrap_number\" style=\"float: right;\">\r\n            ");
            EndContext();
            BeginContext(2634, 152, false);
#line 58 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Grid.cshtml"
       Write(Html.GridPager(Model.Index, Model.Size, Model.Count, Model.Pages,
                PageUrl,"divGrid",
                Model.HasPrevious, Model.HasNext));

#line default
#line hidden
            EndContext();
            BeginContext(2786, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetCore.DataLayer.Paging.IPaginate<DotNetCore.DomainModel.EmployeeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
