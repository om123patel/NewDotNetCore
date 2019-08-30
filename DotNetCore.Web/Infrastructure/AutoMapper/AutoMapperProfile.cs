using AutoMapper;
using DotNetCore.DomainModel;
using DotNetCore.Model;

namespace DotNetCore.Web.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Country, CountryModel>().ReverseMap();
            CreateMap<Department, DepartmentModel>().ReverseMap();
            CreateMap<Employee, EmployeeModel>().ReverseMap();
            CreateMap<Designation, DesignationModel>().ReverseMap();
        }
    }
}