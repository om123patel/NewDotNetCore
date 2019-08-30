﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetCore.DataLayer.Paging
{
    public class Paginate<T> : IPaginate<T>
    {
        internal Paginate(IEnumerable<T> source, int index, int size, int from, string sortBy, string sortDirection)
        {
            var enumerable = source as T[] ?? source.ToArray();

            if (from > index)
                throw new ArgumentException($"indexFrom: {from} > pageIndex: {index}, must indexFrom <= pageIndex");

            Index = index;
            Size = size;
            From = from;
            SortBy = sortBy;
            SortDirection = sortDirection;

            if (source is IQueryable<T> querable)
            {
                Count = querable.Count();
                Pages = (int) Math.Ceiling(Count / (double) Size);
                Items = querable.Skip((Index - From) * Size).Take(Size).ToList();
            }
            else
            {
                Count = enumerable.Count();
                Pages = (int) Math.Ceiling(Count / (double) Size);
                Items = enumerable.Skip((Index - From) * Size).Take(Size).ToList();
            }
        }

        internal Paginate()
        {
            Items = new T[0];
        }

        public int From { get; set; }
        public int Index { get; set; }
        public int Size { get; set; }
        public int Count { get; set; }
        public int Pages { get; set; }
        public IList<T> Items { get; set; }
        public bool HasPrevious => Index - From > 0;
        public bool HasNext => Index - From + 1 < Pages;
        public string SortBy { get; set; }
        public string SortDirection { get; set; }
    }
    internal class Paginate<TSource, TResult> : IPaginate<TResult>
    {
        public Paginate(
            IEnumerable<TSource> source, 
            Func<IEnumerable<TSource>, IEnumerable<TResult>> converter,
            int index, 
            int size, 
            int from,
            string sortBy, 
            string sortDirection)
        {
            var enumerable = source as TSource[] ?? source.ToArray();

            if (from > index) throw new ArgumentException($"From: {from} > Index: {index}, must From <= Index");

            Index = index;
            Size = size;
            From = from;
            SortBy = sortBy;
            SortDirection = sortDirection; 

            if (source is IQueryable<TSource> queryable)
            {
                Count = queryable.Count();
                Pages = (int) Math.Ceiling(Count / (double) Size);
                var items = queryable.Skip((Index - From) * Size).Take(Size).ToArray();
                Items = new List<TResult>(converter(items));
            }
            else
            {
                Count = enumerable.Count();
                Pages = (int) Math.Ceiling(Count / (double) Size);
                var items = enumerable.Skip((Index - From) * Size).Take(Size).ToArray();
                Items = new List<TResult>(converter(items));
            }
        }


        public Paginate(IPaginate<TSource> source, Func<IEnumerable<TSource>, IEnumerable<TResult>> converter)
        {
            Index = source.Index;
            Size = source.Size;
            From = source.From;
            Count = source.Count;
            Pages = source.Pages;
            SortBy = source.SortBy;
            SortDirection = source.SortDirection;

            Items = new List<TResult>(converter(source.Items));
        }
        public int Index { get; }
        public int Size { get; }
        public int Count { get; }
        public int Pages { get; }
        public int From { get; }
        public IList<TResult> Items { get; }
        public bool HasPrevious => Index - From > 0;
        public bool HasNext => Index - From + 1 < Pages;
        public string SortBy { get; set; }
        public string SortDirection { get; set; }
    }
    public static class Paginate
    {
        public static IPaginate<T> Empty<T>()
        {
            return new Paginate<T>();
        }

        public static IPaginate<TResult> From<TResult, TSource>(IPaginate<TSource> source,
            Func<IEnumerable<TSource>, IEnumerable<TResult>> converter)
        {
            return new Paginate<TSource, TResult>(source, converter);
        }
    }
}