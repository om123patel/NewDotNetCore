using System.Collections.Generic;

namespace DotNetCore.Service
{
    public interface IService<T>
    {
        T GetById(int Id);
        IEnumerable<T> GetAll();

        bool Add(T entity);
        bool Update(T entity);

        bool Remove(int Id);
        bool Remove(T entity);
        


    }
}
