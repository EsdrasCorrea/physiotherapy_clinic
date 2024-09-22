using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Clinic.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicalConsulationController : ControllerBase
    {
        public MedicalConsulationController()
        {
            
        }

        [HttpGet]
        public string Get()
        {
            return "value";
        }
        
    }
}