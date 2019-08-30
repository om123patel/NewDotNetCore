using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using DotNetCore.Utilities.Constants;
using System.Text;

namespace DotNetCore.Components
{
    public static class HtmlHelperExtensions
    {
        #region Pagination Html Helper
        public static IHtmlContent GridPager(this IHtmlHelper helper, int index, int pageSize, int itemCount, int pages, string pageUrl, string targetDiv, bool HasPrevious = true, bool HasNext = true, int totalPageLink = Pagination.DEFAULT_PAGE_LINK)
        {
            if (itemCount <= 0)
                return new HtmlString(string.Empty);

            var lastPageNumber = (int)Math.Ceiling((double)index / totalPageLink) * totalPageLink;
            var firstPageNumber = lastPageNumber - (totalPageLink - 1);

            if (lastPageNumber > pages)
                lastPageNumber = pages;

            var ul = new TagBuilder("ul");
            ul.AddCssClass(Pagination.CSS_UL_CLASS);

            ul.InnerHtml.AppendHtml(AddLink(1, pageUrl, targetDiv, index == 1, Pagination.CSS_DISABLED, Pagination.FIRST_TEXT, Pagination.FIRST_TEXT_TOOLTIP).ToString());
            ul.InnerHtml.AppendHtml(AddLink(index - 1, pageUrl, targetDiv, !HasPrevious, Pagination.CSS_DISABLED, Pagination.PREVIOUS_TEXT, Pagination.PREVIOUS_TEXT_TOOLTIP).ToString());

            for (int i = firstPageNumber; i <= lastPageNumber; i++)
            {
                ul.InnerHtml.AppendHtml(AddLink(i, pageUrl, targetDiv, i == index, Pagination.CSS_ACTIVE, i.ToString(), i.ToString()).ToString());
            }

            ul.InnerHtml.AppendHtml(AddLink(index + 1, pageUrl, targetDiv, !HasNext, Pagination.CSS_DISABLED, Pagination.NEXT_TEXT, Pagination.NEXT_TEXT_TOOLTIP).ToString());
            ul.InnerHtml.AppendHtml(AddLink(pages, pageUrl, targetDiv, index == pages, Pagination.CSS_DISABLED, Pagination.LAST_TEXT, Pagination.LAST_TEXT_TOOLTIP).ToString());

            return new HtmlString(ExtensionUtilities.ConvertToString(ul));
        }

        public static IHtmlContent GridCountDetails(this IHtmlHelper helper, int currentPage, int pageSize, int recordCount)
        {
            TagBuilder divContainer = new TagBuilder("div");
            divContainer.AddCssClass("tr");
            if (recordCount > 0)
            {
                string detailsText = "";

                int startingNumber = ((currentPage - 1) * pageSize) + 1;
                int endingNumber = currentPage * pageSize;
                endingNumber = endingNumber > recordCount ? recordCount : endingNumber;

                TagBuilder startingNumberspan = new TagBuilder("span");
                startingNumberspan.InnerHtml.SetContent(startingNumber.ToString());

                TagBuilder endingNumberspan = new TagBuilder("span");
                endingNumberspan.InnerHtml.SetContent(endingNumber.ToString());

                TagBuilder totalNumberspan = new TagBuilder("span");
                totalNumberspan.InnerHtml.SetContent(recordCount.ToString());

                detailsText = string.Format("Showing {0} to {1} of {2} entries", ExtensionUtilities.ConvertToString(startingNumberspan), ExtensionUtilities.ConvertToString(endingNumberspan), ExtensionUtilities.ConvertToString(totalNumberspan));
                divContainer.InnerHtml.AppendHtml(detailsText);
            }
            return new HtmlString(ExtensionUtilities.ConvertToString(divContainer));
        }

        public static IHtmlContent GridPageSize(this IHtmlHelper helper, int pageSize, string pageUrl, string TagetDiv)
        {
            var selecttag = new TagBuilder("select");
            selecttag.Attributes.Add("name", "PageSize");
            selecttag.Attributes.Add("id", "PageSizeId");
            selecttag.AddCssClass("form-control");
            selecttag.AddCssClass("width-auto");
            selecttag.Attributes.Add("onchange", "gridReload('" + pageUrl + "','" + TagetDiv + "'," + 1 + ");");

            var options = new StringBuilder();

            var defaultOpt4 = new TagBuilder("option");
            defaultOpt4.MergeAttribute("value", Pagination.DEFAULT_PAGE_SIZE.ToString());
            defaultOpt4.InnerHtml.SetContent("Default");
            if (pageSize == Pagination.DEFAULT_PAGE_SIZE)
                defaultOpt4.Attributes.Add("Selected", "Selected");
            options.Append(ExtensionUtilities.ConvertToString(defaultOpt4));

            var defaultOpt = new TagBuilder("option");
            defaultOpt.MergeAttribute("value", "10");
            defaultOpt.InnerHtml.SetContent("10");
            if (pageSize == 10)
                defaultOpt.Attributes.Add("Selected", "Selected");

            options.Append(ExtensionUtilities.ConvertToString(defaultOpt));

            var defaultOpt1 = new TagBuilder("option");
            defaultOpt1.MergeAttribute("value", "20");
            defaultOpt1.InnerHtml.SetContent("20");
            if (pageSize == 20)
                defaultOpt1.Attributes.Add("Selected", "Selected");
            options.Append(ExtensionUtilities.ConvertToString(defaultOpt1));

            var defaultOpt2 = new TagBuilder("option");
            defaultOpt2.MergeAttribute("value", "50");
            defaultOpt2.InnerHtml.SetContent("50");
            if (pageSize == 50)
                defaultOpt2.Attributes.Add("Selected", "Selected");
            options.Append(ExtensionUtilities.ConvertToString(defaultOpt2));

            var defaultOpt3 = new TagBuilder("option");
            defaultOpt3.MergeAttribute("value", "100");
            defaultOpt3.InnerHtml.SetContent("100");
            if (pageSize == 100)
                defaultOpt3.Attributes.Add("Selected", "Selected");
            options.Append(ExtensionUtilities.ConvertToString(defaultOpt3));

            selecttag.InnerHtml.AppendHtml(options.ToString());
            return new HtmlString(ExtensionUtilities.ConvertToString(selecttag));
        }

        private static string AddLink(int index,string PageUrl, string tagetDiv, bool condition, string cssClass, string linkText, string toolTip)
        {
            var li = new TagBuilder("li");
            li.MergeAttribute("title", toolTip);
            if (condition)
                li.AddCssClass(cssClass);
            var a = new TagBuilder("a");

            if(!condition)
                a.MergeAttribute("onclick", "gridReload('" + PageUrl + "','" + tagetDiv + "'," + index + ");");

            //a.MergeAttribute("href", !condition ? action(index) : "javascript:");
            a.InnerHtml.SetContent(linkText);
            li.InnerHtml.AppendHtml(a);
            return ExtensionUtilities.ConvertToString(li);
        }

        #endregion

        #region Sorting Html Helper
        public static IHtmlContent SortingControl(this IHtmlHelper helper, string targetURL, string targetContainerId)
        {
            StringBuilder tags = new StringBuilder();

            tags.Append(
                "<script type='text/javascript'> " +
                "$(document).ready(function()" +
                "{ " +
                "setGridSortingUrl('" + targetURL + "','" + targetContainerId + "');" +
                "}); " +
                "</script>");

            return new HtmlString(tags.ToString());
        }
        #endregion
    }
}
