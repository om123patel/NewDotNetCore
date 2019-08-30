using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCore.Model
{
    public partial class State : Entity<int>
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Code { get; set; }

        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country country { get; set; }
    }
}
