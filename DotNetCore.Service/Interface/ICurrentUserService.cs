using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.Service.Interface
{
    public class ICurrentUserService
    {
        string UserName { get; }
        string UserId { get; }
        string HostIP { get; }
    }
}
