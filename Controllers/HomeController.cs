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
        private AppointmentContext _appointmentContext { get; set; }

        public HomeController(AppointmentContext x)
        {
            _appointmentContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            ViewBag.Appointments = _appointmentContext.responses.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Signup(MakeAppointment signup)
        {
            _appointmentContext.Add(signup);
            _appointmentContext.SaveChanges();
            return View("Index", signup);
        }

        public IActionResult ViewAppointments()
        {
            var x = _appointmentContext.responses
                .OrderBy(x=> x.AppointmentId)
                .ToList();
            return View(x);
        }

        public IActionResult EditAppointments()
        {
            return View();
        }

        public IActionResult Calendar()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View("Signup");
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
