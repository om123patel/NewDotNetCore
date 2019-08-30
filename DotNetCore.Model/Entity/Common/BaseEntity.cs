using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCore.Model
{
    public abstract class BaseEntity 
    {
        public virtual bool IsActive { get; set; }

        [Timestamp]
        public virtual byte[] TimeStamp { get; set; }
    }
}
