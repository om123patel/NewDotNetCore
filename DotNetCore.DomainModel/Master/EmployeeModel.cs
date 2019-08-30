using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore.DomainModel
{
    public class EmployeeModel : BaseDomainModel<long>
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Code")]
        public string Code { get; set; }

        public short DepartmentId { get; set; }
        public short DesignationId { get; set; }

        public DepartmentModel Department { get; set; }
        public DesignationModel Designation { get; set; }

        public List<SelectListItem> DesignationList { get; set; }
        public List<SelectListItem> DepartmentList { get; set; }
    }
}
