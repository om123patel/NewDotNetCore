using AutoMapper;
using DotNetCore.Components;
using DotNetCore.DataLayer;
using DotNetCore.DataLayer.Paging;
using DotNetCore.DomainModel;
using DotNetCore.Model;
using DotNetCore.Utilities.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DotNetCore.Service
{
    public class EmployeeService : EntityService<Employee, EmployeeModel>, IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IMapper mapper, IUnitOfWork unitOfWork, IEmployeeRepository employeeRepository)
            : base(mapper, unitOfWork, employeeRepository)
        {
            _unitOfWork = unitOfWork;
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public EmployeeModel GetById(int Id)
        {
            var model = _employeeRepository.FindBy(d => d.Id == Id).SingleOrDefault();
            return _mapper.Map<EmployeeModel>(model);
        }

        public IPaginate<EmployeeModel> GetList(int? index, int? pageSize, string sortColumn, string sortDirection)
        {

            var model = _employeeRepository.GetList<EmployeeModel>(
                 selector: source => new EmployeeModel
                 {
                     Id = source.Id,
                     FirstName = source.FirstName,
                     MiddleName = source.MiddleName,
                     LastName = source.LastName,
                     Code = source.Code,
                     Designation = new DesignationModel
                     {
                         Name = source.Designation.Name,
                         Id = source.Designation.Id,
                         Code = source.Designation.Code
                     },
                     Department = new DepartmentModel
                     {
                         Name = source.Department.Name,
                         Id = source.Department.Id,
                         Code = source.Department.Code
                     }
                 },
                 predicate: null,
                 orderBy: sortColumn.OrderByString(sortDirection),
                 include: source => source
                .Include(d => d.Department)
                .Include(d => d.Designation),
                 index: index ?? 1,
                 size: pageSize ?? Pagination.DEFAULT_PAGE_SIZE,
                 disableTracking: false);

            return model;
        }


    }
}
