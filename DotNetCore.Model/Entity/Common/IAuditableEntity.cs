using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.Model
{
    public interface IAuditableEntity
    {
        long CreatedBy { get; set; }

        DateTime CreatedOn { get; set; }

        long? UpdatedBy { get; set; }

        DateTime? UpdatedOn { get; set; }

        User UserCreatedBy { get; set; }

        User UserUpdatedBy { get; set; }
    }
}
