using DotNetCore.DataLayer.Paging;
using DotNetCore.DomainModel;
using DotNetCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.Service
{
    public interface IEmployeeService : IEntityService<Employee, EmployeeModel>
    {
        EmployeeModel GetById(int Id);
        IPaginate<EmployeeModel> GetList(int? index, int? pageSize, string sortColumn, string sortingDirection);
    }
}
