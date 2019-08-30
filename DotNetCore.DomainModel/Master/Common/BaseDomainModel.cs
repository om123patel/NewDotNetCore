using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotNetCore.DomainModel
{
    public abstract class BaseDomainModel<T> 
    {
        public virtual T Id { get; set; }

        public virtual bool IsActive { get; set; }

        [Timestamp]
        public virtual byte[] TimeStamp { get; set; }
    }
}
