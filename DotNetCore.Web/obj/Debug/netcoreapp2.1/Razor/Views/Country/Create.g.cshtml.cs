#pragma checksum "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3eb62445026b6613cbaf9e73511d66e86e59dad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Country_Create), @"mvc.1.0.view", @"/Views/Country/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Country/Create.cshtml", typeof(AspNetCore.Views_Country_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3eb62445026b6613cbaf9e73511d66e86e59dad", @"/Views/Country/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10598856f6258f03fe623e81ec372034dd78e46b", @"/Views/_ViewImports.cshtml")]
    public class Views_Country_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotNetCore.DomainModel.CountryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(84, 23, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
            BeginContext(143, 23, false);
#line 12 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(174, 69, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Country</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(244, 28, false);
#line 17 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(272, 42, true);
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(315, 77, false);
#line 20 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
   Write(Html.LabelFor(model => model.Name, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(392, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(440, 36, false);
#line 22 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(476, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(491, 46, false);
#line 23 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(537, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(606, 77, false);
#line 27 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
   Write(Html.LabelFor(model => model.Code, new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(683, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(731, 36, false);
#line 29 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(767, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(782, 46, false);
#line 30 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(828, 223, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 40 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
}

#line default
#line hidden
            BeginContext(1054, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1068, 40, false);
#line 43 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Country\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1120, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ba115cd62d54fee9d99b1f43151ba6a", async() => {
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
            BeginContext(1174, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1176, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b1d7ddf67da4d8a9479f732fca5342b", async() => {
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
            BeginContext(1232, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1234, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da8c9bf103ae415c9d457d9cb9b53c05", async() => {
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
            BeginContext(1302, 2, true);
            WriteLiteral("\r\n");
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