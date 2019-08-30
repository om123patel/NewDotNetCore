using System;
using System.Collections.Generic;

namespace DotNetCore.DataLayer.Paging
{
    public static class PaginateExtensions
    {
        public static IPaginate<T> ToPaginate<T>(
            this IEnumerable<T> source, 
            int index, 
            int size, 
            string sortBy,
            string sortDirection,
            int from = 1)
        {
            return new Paginate<T>(source, index, size, from, sortBy, sortDirection);
        }

        public static IPaginate<TResult> ToPaginate<TSource, TResult>(
            this IEnumerable<TSource> source,
            Func<IEnumerable<TSource>, IEnumerable<TResult>> converter, 
            int index, 
            int size,
            string sortBy,
            string sortDirection,
            int from = 1)
        {
            return new Paginate<TSource, TResult>(source, converter, index, size, from, sortBy, sortDirection);
        }
    }
}