using DotNetCore.DataLayer.Paging;
using DotNetCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Linq.Dynamic.Core;


namespace DotNetCore.DataLayer
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        #region Variables
        private readonly IUnitOfWork _unitOfWork;
        protected readonly DbSet<T> _dbset;
        #endregion

        #region Ctor
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _dbset = _unitOfWork.Context.Set<T>();
        }
        #endregion

        #region Add Data
        public virtual void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Add(params T[] entities)
        {
            _dbset.AddRange(entities);
        }

        public virtual void Add(IEnumerable<T> entities)
        {
            _dbset.AddRange(entities);
        }

        #endregion

        #region Update Data
        public virtual void Update(T entity)
        {
            _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Update(params T[] entities)
        {
            _dbset.UpdateRange(entities);
        }

        public virtual void Update(IEnumerable<T> entities)
        {
            _dbset.UpdateRange(entities);
        }

        #endregion

        #region Delete Data
        public virtual void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public virtual void Delete(object id)
        {
            var typeInfo = typeof(T).GetTypeInfo();
            var key = _unitOfWork.Context.Model.FindEntityType(typeInfo).FindPrimaryKey().Properties.FirstOrDefault();
            var property = typeInfo.GetProperty(key?.Name);
            if (property != null)
            {
                var entity = _dbset.Find(id);
                if (entity != null) Delete(entity);

                //var entity = Activator.CreateInstance<T>();
                //property.SetValue(entity, id);
                //_unitOfWork.Context.Entry(entity).State = EntityState.Deleted;
            }
            else
            {
                var entity = _dbset.Find(id);
                if (entity != null) Delete(entity);
            }
        }

        public virtual void Delete(params T[] entities)
        {
            _dbset.RemoveRange(entities);
        }

        public virtual void Delete(IEnumerable<T> entities)
        {
            _dbset.RemoveRange(entities);
        }

        #endregion

        #region Read Data
        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }
        public virtual IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbset;

            if (disableTracking) query = query.AsNoTracking();

            if (include != null) query = include(query);

            if (predicate != null)
                query = _dbset.Where(predicate);

            return query.AsEnumerable<T>();
        }


        public virtual IQueryable<T> Query(string sql, params object[] parameters) => _dbset.FromSql(sql, parameters);

        public virtual T Search(params object[] keyValues) => _dbset.Find(keyValues);


        public virtual T Single(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbset;
            if (disableTracking) query = query.AsNoTracking();

            if (include != null) query = include(query);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return orderBy(query).FirstOrDefault();
            return query.FirstOrDefault();
        }

        public virtual IPaginate<T> GetList(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            int index = 0,
            int size = 20,
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbset;
            if (disableTracking) query = query.AsNoTracking();

            if (include != null) query = include(query);

            if (predicate != null) query = query.Where(predicate);

            //return orderBy != null ? 
            //    orderBy(query).ToPaginate(index, size) : 
            //    query.ToPaginate(index, size);

            string orderBy1 = "";

            string[] sortBy = orderBy1.Split(" ");

            return query.ToPaginate(index, size, sortBy[0], sortBy[1]);
        }


        public virtual IPaginate<TResult> GetList<TResult>(
            Expression<Func<T, TResult>> selector,
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            int index = 1,
            int size = 20,
            bool disableTracking = true) where TResult : class
        {
            IQueryable<T> query = _dbset;
            if (disableTracking) query = query.AsNoTracking();

            if (include != null) query = include(query);

            if (predicate != null) query = query.Where(predicate);

            //return orderBy != null
            //    ? orderBy(query).Select(selector).ToPaginate(index, size)
            //    : query.Select(selector).ToPaginate(index, size);
            string orderBy1 = "";

            string[] sortBy = orderBy1.Split(" ");

            return query.Select(selector).ToPaginate(index, size, sortBy[0], sortBy[1]);
        }

        public IPaginate<T> GetList(Expression<Func<T, bool>> predicate = null, 
            string orderBy = "", 
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, 
            int index = 0, 
            int size = 20, 
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbset;
            if (disableTracking) query = query.AsNoTracking();

            if (include != null) query = include(query);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null) query = query.OrderBy(orderBy);

            string[] sortBy = orderBy.Split(" ");

            return query.ToPaginate(index, size, sortBy[0], sortBy[1]);
        }

        public IPaginate<TResult> GetList<TResult>(Expression<Func<T, TResult>> selector, 
            string orderBy = "", 
            Expression<Func<T, bool>> predicate = null, 
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, 
            int index = 0, 
            int size = 20, 
            bool disableTracking = true) where TResult : class
        {
            IQueryable<T> query = _dbset;
            if (disableTracking) query = query.AsNoTracking();

            if (include != null) query = include(query);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null) query = query.OrderBy(orderBy);

            //return query.Select(selector).ToPaginate(index, size);

            string[] sortBy = orderBy.Split(" ");

            return query.Select(selector).ToPaginate(index, size, sortBy[0], sortBy[1]);
        }

        public IPaginate<T> GetList(string orderBy, 
            Expression<Func<T, bool>> predicate = null, 
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, 
            int index = 0, 
            int size = 20, 
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbset;

            query = query.OrderBy(orderBy);

            if (disableTracking) query = query.AsNoTracking();

            if (include != null) query = include(query);

            if (predicate != null) query = query.Where(predicate);

            string[] sortBy = orderBy.Split(" ");

            return query.ToPaginate(index, size, sortBy[0], sortBy[1]);
        }

        public IPaginate<T> GetList(string orderBy, 
            string predicate = null, 
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, 
            int index = 0, 
            int size = 20, 
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbset;

            query = query.OrderBy(orderBy);

            if (disableTracking) query = query.AsNoTracking();

            if (include != null) query = include(query);

            if (predicate != null) query = query.Where(predicate);

            string[] sortBy = orderBy.Split(" ");

            return query.ToPaginate(index, size, sortBy[0], sortBy[1]);
        }
        #endregion
    }
}
