using AutoMapper;
using DotNetCore.DataLayer;
using DotNetCore.DomainModel;
using DotNetCore.Model;

namespace DotNetCore.Service
{
    public class DesignationService : EntityService<Designation, DesignationModel>, IDesignationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDesignationRepository _designationRepository;
        private readonly IMapper _mapper;
        public DesignationService(IMapper mapper, IUnitOfWork unitOfWork, IDesignationRepository designationRepository)
            : base(mapper,unitOfWork, designationRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _designationRepository = designationRepository;
        }
    }
}
