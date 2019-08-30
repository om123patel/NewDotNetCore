using Microsoft.EntityFrameworkCore;
using System;

namespace DotNetCore.DataLayer
{
    /// <summary>
    /// The Entity Framework implementation of IUnitOfWork
    /// </summary>
    public sealed class UnitOfWork : IUnitOfWork
    {
        private DbContext _dbContext;

        public DbContext Context
        {
            get { return _dbContext ?? (_dbContext = new DotNetCoreContext()); }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }


        /// <summary>
        /// Disposes the current object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Context != null)
                {
                    Context.Dispose();
                }
            }
        }
    }
}
