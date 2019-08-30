using System.Collections.Generic;

namespace DotNetCore.Model
{
    public class User
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public virtual ICollection<Employee> EmployeeCreatedBy { get; set; } = new HashSet<Employee>();
        public virtual ICollection<Employee> EmployeeUpdatedBy { get; set; } = new HashSet<Employee>();
        public virtual ICollection<Employee> EmployeeDeletedBy { get; set; } = new HashSet<Employee>();

      


    }

   
}
