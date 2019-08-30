using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.Model
{
    public interface ISoftDelete
    {

        long? DeletedBy { get; set; }
        DateTime? DeletedOn { get; set; }

        bool IsDeleted { get; set; }

        User UserDeletedBy { get; set; }
    }
}
