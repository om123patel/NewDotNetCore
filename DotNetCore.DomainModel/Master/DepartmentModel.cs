using System.ComponentModel.DataAnnotations;

namespace DotNetCore.DomainModel
{
    public class DepartmentModel : BaseDomainModel<int>
    {
        [Display(Name = "Department Name")]
        public string Name { get; set; }

        [Display(Name = "Department Code")]
        public string Code { get; set; }

    }
}
