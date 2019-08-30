using DotNetCore.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.Components
{
    public static class StringExtensions
    {
        public static string OrderByString(this string SortColumn, string sortDirection)
        {
            return SortColumn + " " + (sortDirection ?? SortingDirection.ASC.ToString());
        }
    }
}
