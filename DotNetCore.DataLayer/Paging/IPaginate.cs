using System.Collections.Generic;

namespace DotNetCore.DataLayer.Paging
{
    public interface IPaginate<TEntity>
    {
        int From { get; }

        int Index { get; }

        int Size { get; }

        int Count { get; }

        int Pages { get; }

        IList<TEntity> Items { get; }

        bool HasPrevious { get; }

        bool HasNext { get; }

        string SortBy { get; }

        string SortDirection { get; }
    }
}