using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotNetCore.Model
{
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        [ScaffoldColumn(false)]
        public virtual long CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public virtual DateTime CreatedOn { get; set; }

        [ScaffoldColumn(false)]
        public virtual long? UpdatedBy { get; set; }

        [ScaffoldColumn(false)]
        public virtual DateTime? UpdatedOn { get; set; }

        [ScaffoldColumn(false)]
        public virtual User UserCreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public virtual User UserUpdatedBy { get; set; }
    }

}
