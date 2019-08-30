using DotNetCore.Model;

namespace DotNetCore.DataLayer
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepartmentRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
