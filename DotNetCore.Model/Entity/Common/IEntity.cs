using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.Model
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
