using System.ComponentModel.DataAnnotations;

namespace DotNetCore.DomainModel
{
    public class DesignationModel : BaseDomainModel<int>
    {
        [Display(Name = "Designation Name")]
        public string Name { get; set; }

        [Display(Name = "Designation Code")]
        public string Code { get; set; }
    }
}
