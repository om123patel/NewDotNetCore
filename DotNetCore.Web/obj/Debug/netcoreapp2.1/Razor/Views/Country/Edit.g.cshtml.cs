#pragma checksum "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d9a89ccc2fb2f7fec8771c734d28cf2c47e60e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Country_Edit), @"mvc.1.0.view", @"/Views/Country/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Country/Edit.cshtml", typeof(AspNetCore.Views_Country_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d9a89ccc2fb2f7fec8771c734d28cf2c47e60e9", @"/Views/Country/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10598856f6258f03fe623e81ec372034dd78e46b", @"/Views/_ViewImports.cshtml")]
    public class Views_Country_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetCore.DomainModel.CountryModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
            BeginContext(82, 19, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(136, 23, false);
#line 11 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(167, 69, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Country</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(237, 28, false);
#line 16 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(265, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(272, 33, false);
#line 17 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(305, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(312, 40, false);
#line 18 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
Write(Html.HiddenFor(model => model.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(352, 42, true);
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(395, 77, false);
#line 21 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
   Write(Html.LabelFor(model => model.Name, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(472, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(520, 36, false);
#line 23 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(556, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(571, 46, false);
#line 24 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(617, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(686, 77, false);
#line 28 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
   Write(Html.LabelFor(model => model.Code, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(763, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(811, 36, false);
#line 30 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(847, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(862, 46, false);
#line 31 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(908, 221, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 41 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(1132, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1146, 40, false);
#line 44 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotNetCore.DomainModel.CountryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
