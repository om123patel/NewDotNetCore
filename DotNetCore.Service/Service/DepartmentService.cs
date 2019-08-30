using AutoMapper;
using DotNetCore.DataLayer;
using DotNetCore.DomainModel;
using DotNetCore.Model;

namespace DotNetCore.Service
{
    public class DepartmentService : EntityService<Department, DepartmentModel>, IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IMapper mapper, IUnitOfWork unitOfWork, IDepartmentRepository departmentRepository)
            :base(mapper, unitOfWork, departmentRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _departmentRepository = departmentRepository;
        }
    }
}
