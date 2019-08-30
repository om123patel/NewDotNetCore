using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore.Model
{
    public partial class Country : Entity<int>
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Code { get; set; }

        public virtual ICollection<State> States { get; set; } = new HashSet<State>();
    }
}
