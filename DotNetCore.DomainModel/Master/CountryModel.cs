using System.ComponentModel.DataAnnotations;

namespace DotNetCore.DomainModel
{
    public class CountryModel : BaseDomainModel<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
