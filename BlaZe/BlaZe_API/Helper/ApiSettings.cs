using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaZe_API.Helper
{
    public class ApiSettings
    {
        public string SecretKey { get; set; }
        public string ValidAudiencce { get; set; }
        public string ValidIssuer { get; set; }
    }
}
