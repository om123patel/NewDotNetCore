using DotNetCore.Service.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.Service.Service
{
    public class CurrentWebUserService : ICurrentUserService
    {
        public CurrentWebUserService(HttpContext context) {

        }

        public string UserName { get; set; }
    }
}
