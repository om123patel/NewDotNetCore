using DotNetCore.DataLayer;
using DotNetCore.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DotNetCore.Repository
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public CountryRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Country GetById(int Id)
        {
            return FindBy(d => d.Id == Id).SingleOrDefault();
        }


    }
}
