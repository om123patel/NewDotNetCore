using System.Collections.Generic;

namespace DotNetCore.Service
{
    //public interface IEntityService<T> : IService
    public interface IEntityService<TEntity, TDomain> 
    where TEntity : class
    where TDomain : class
    {
        void Create(TDomain entity);
        void Update(TDomain entity);
        void Delete(object Id);
        IEnumerable<TDomain> GetAll();
    }
}
