using DotNetCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetCore.DataLayer
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override IEnumerable<Employee> GetAll()
        {
            return _dbset
                   .Include(x => x.Department)
                   .Include(x => x.Designation)
                   .AsEnumerable();
        }
    }
}
