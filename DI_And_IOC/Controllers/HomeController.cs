using DI_And_IOC.Models;
using DI_And_IOC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DI_And_IOC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //ctor vasıtası ile erişim
        readonly ILog _afaLog;

        public HomeController(ILogger<HomeController> logger, ILog afaLog)
        {
            _logger = logger;
            _afaLog = afaLog;
        }

        public IActionResult Index()
        {
            return View();
        }
        //action içerisinde servislere erişim
        public IActionResult Privacy([FromServices]ILog log)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
