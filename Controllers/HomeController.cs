using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission12.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AppointmentContext _appointmentContext { get; set; }

        public HomeController(ILogger<HomeController> logger, AppointmentContext x)
        {
            _logger = logger;
            _appointmentContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(MakeAppointment signup)
        {
            _appointmentContext.Add(signup);
            _appointmentContext.SaveChanges();
            return View("Confirmation", signup);
        }

        public IActionResult ViewAppointments()
        {
            return View();
        }

        public IActionResult EditAppointments()
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
