using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldAPI
{
    [ApiController]
    [Route("/api/hello")]
    public class HelloWorldController : ControllerBase
    {
        private static int _counter = 0;
        private readonly IConfiguration _config;

        public HelloWorldController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public async Task<IActionResult> Hello()
        {
            return Ok(new {
                Message = "Hello World",
                Now = DateTime.Now,
                Count = _counter++,
                Name = _config["AppName"]
            });
        }
    }
}
