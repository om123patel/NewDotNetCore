using System.Collections.Generic;

namespace DotNetCore.Model
{
    public partial class Designation : Entity<short>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }

   
}
