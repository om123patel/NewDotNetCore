using Microsoft.EntityFrameworkCore;
using System;

namespace DotNetCore.DataLayer
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }
        void Commit();
    }
}
