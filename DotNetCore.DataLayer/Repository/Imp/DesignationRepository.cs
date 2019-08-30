using DotNetCore.Model;

namespace DotNetCore.DataLayer
{
    public class DesignationRepository : BaseRepository<Designation>, IDesignationRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public DesignationRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
