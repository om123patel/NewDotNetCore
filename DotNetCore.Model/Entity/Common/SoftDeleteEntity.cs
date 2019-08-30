using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DotNetCore.Model
{
    public abstract class SoftDeleteEntity : ISoftDelete
    {
        [ScaffoldColumn(false)]
        public virtual long? DeletedBy { get; set; }

        [ScaffoldColumn(false)]
        public virtual DateTime? DeletedOn { get; set; }

        [ScaffoldColumn(false)]
        public virtual bool IsDeleted { get; set; }

        [ScaffoldColumn(false)]
        public virtual User UserDeletedBy { get; set; }
    }
}
