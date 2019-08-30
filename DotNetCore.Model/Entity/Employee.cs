using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCore.Model
{
    public partial class Employee : AuditableEntity<long>, ISoftDelete
    {
       
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get;set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
        
        public string Code { get; set; }

        public short DepartmentId { get; set; }

        public short DesignationId { get; set; }

        public virtual Department Department { get; set; }

        public virtual Designation Designation { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
        public User UserDeletedBy { get; set; }
    }

  
}
