#pragma checksum "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47ed6208269bf22e50c0d48563398d857bfd31a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47ed6208269bf22e50c0d48563398d857bfd31a1", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10598856f6258f03fe623e81ec372034dd78e46b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(41, 39, true);
            WriteLiteral("\r\n<h2>Employee Master</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(81, 36, false);
#line 8 "C:\Anil\Practice Projects\Core Demo\DotNetCore\DotNetCore.Web\Views\Employee\Index.cshtml"
Write(Html.ActionLink("Add New", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(117, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(157, 36, true);
            WriteLiteral("<div id=\"divGrid\">\r\n\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(210, 2896, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {
            gridReload('Employee/Grid', 'divGrid', 1);
        })


        function gridReload(pageUrl, targetDiv, currentPage, pageSize) {
            GridLoad(pageUrl, targetDiv, currentPage, pageSize);
        }

        function setGridSortingUrl(searchUrl, targetDiv) {
            var $table = $(""#"" + targetDiv + "" table"");
            if ($table.length > 0 && $table.data(""sorting"") === true) {

                var sortBy = $table.data('sortBy');
                var sortDirection = $table.data('sortdirection');

                $table.find('thead tr th').each(function () {
                    var th = $(this);
                    var text = th.text();
                    var columnName = th.data('columnname');
                    th.text('');
                    var isSort = sortBy === columnName;
                    debugger
                    if (isSort)
                        sortDirection = sor");
                WriteLiteral(@"tDirection == ""DESC"" ? ""ASC"" : sortDirection;

                    var link = CreateSortingLink(columnName, sortDirection, searchUrl, targetDiv, text, isSort);
                    th.append(link);
                });
            }
        }

        function CreateSortingLink(ColumnName, sortDirection, searchUrl, targetDiv, text, isSort) {
            var link = $(""<a>"");
            link.attr(""href"", ""javascript:void(0)"");
            link.attr(""onclick"", ""GridSorting('"" + ColumnName + ""', '"" + sortDirection + ""', '"" + searchUrl + ""', '"" + targetDiv + ""');return false;"");
            link.text(text);
            link.addClass(sortDirection);
            return link;
        }

        function GridSorting(columnValue, orderValue, searchUrl, targetDiv) {
            GridLoad(searchUrl, targetDiv, 1, null, columnValue, orderValue);
        }

        function GridLoad(pageUrl, targetDiv, currentPage, pageSize, columnValue, orderValue) {

            if ($(""#PageSizeId"").length > 0)
    ");
                WriteLiteral(@"            pageSize = parseInt($(""#PageSizeId  option:selected"").val());

            PostToServer({
                url: pageUrl,
                data: { Page: currentPage, PageSize: pageSize, SortingColumn: columnValue, SortingDirection: orderValue },
                onSuccess: function (data) {
                    $(""#"" + targetDiv).html(data);
                    setGridSortingUrl(pageUrl, targetDiv);

                    if (data.isValid) {
                        //window.location = urlHomePage;
                    }
                    else {
                        //Message.Error(data.errors[0].ErrorMessages);
                    }
                },
                onError: function (xhr, status, error) {
                    Message.Error(error);
                }
            });
        }
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
