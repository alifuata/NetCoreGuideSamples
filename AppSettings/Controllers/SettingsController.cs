using AppSettings.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSettings.Controllers
{
    [Route("api/[controller]")]
    public class SettingsController : Controller
    {
        readonly IConfiguration _configuration;
        public SettingsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet("GetPersonName")]
        public IActionResult Index()
        {
            return Ok(_configuration["Person:name"]);
        }
        [HttpGet("GetLogLevel")]
        public IActionResult GetLogLevel()
        {
            //indexer kullanarak alma, sadece değer verir
            var vr = _configuration["Logging:LogLevel:Default"];
            //getsection obje olark döner
            var tr = _configuration.GetSection("Person");
            //get metodu ile de modelle eşleştirilerek de alınabilir
            var fr = _configuration.GetSection("Person").Get(typeof(Person));
            return Ok(vr);
        }
    }
}
