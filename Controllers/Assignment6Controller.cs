using Assignment6Names.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Assignment6Names.AddControllers
{
    [ApiController]
    [Route("[controller]")]
    public class Assignment6Controller : ControllerBase
    {
        private ILogger<Assignment6Controller> _logger;

        
        public Assignment6Controller(ILogger<Assignment6Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Assignment6 Get() 
        {
            return new Assignment6
            {
                firstName = "Barack",
                lastName = "Obama",
                major = "Politcs"
            };
        }

    }
}