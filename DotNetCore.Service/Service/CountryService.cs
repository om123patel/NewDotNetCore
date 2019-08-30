using AutoMapper;
using DotNetCore.DataLayer;
using DotNetCore.DomainModel;
using DotNetCore.Model;
using DotNetCore.Repository;
using System.Linq;

namespace DotNetCore.Service
{
    public class CountryService : EntityService<Country, CountryModel>, ICountryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICountryRepository _countryRepository;

        public CountryService(IMapper mapper, IUnitOfWork unitOfWork, ICountryRepository countryRepository)
            :base(mapper, unitOfWork, countryRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _countryRepository = countryRepository;
        }

        public CountryModel GetById(int Id)
        {
            var model = _countryRepository.FindBy(d => d.Id == Id).SingleOrDefault();
            return _mapper.Map<CountryModel>(model);
        }
    }
}
