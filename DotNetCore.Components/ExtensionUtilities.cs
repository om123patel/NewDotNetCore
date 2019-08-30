using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.Components
{
    public class ExtensionUtilities
    {
        public static string ConvertToString(TagBuilder tag)
        {
            string result;
            using (var sw = new System.IO.StringWriter())
            {
                tag.WriteTo(sw, System.Text.Encodings.Web.HtmlEncoder.Default);
                result = sw.ToString();
            }
            return result.ToString();
        }
    }
}
