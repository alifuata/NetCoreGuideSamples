using AppSettings.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSettings.Controllers
{
    [Route("api[controller]/[action]")]
    public class OptionsPatternController : Controller
    {
        Person _person;
        public OptionsPatternController(IOptions<Person> person)
        {
            _person = person.Value;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return Ok(_person);
        }
    }
}
