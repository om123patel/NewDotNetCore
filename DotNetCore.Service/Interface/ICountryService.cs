using DotNetCore.DomainModel;
using DotNetCore.Model;
using System.Collections.Generic;

namespace DotNetCore.Service
{
    public interface ICountryService : IEntityService<Country, CountryModel> 
    {
        CountryModel GetById(int Id);
    }
}
