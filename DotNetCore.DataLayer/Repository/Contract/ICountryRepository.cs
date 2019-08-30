using DotNetCore.DataLayer;
using DotNetCore.Model;

namespace DotNetCore.Repository
{
    public interface ICountryRepository  : IBaseRepository<Country>
    {
        Country GetById(int Id);
    }
}
