using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Appointments = _appointmentContext.tourtimes.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Signup(MakeAppointment signup)
        {
            if (ModelState.IsValid)
            {
                _appointmentContext.Add(signup);
                _appointmentContext.SaveChanges();

                return View("Index", signup);

            }
            else //if invalid
            {
                ViewBag.Appointments = _appointmentContext.tourtimes.ToList();

                return View();
            }
        }

        public IActionResult ViewAppointments()
        {
            var x = _appointmentContext.responses
                .Include(x => x.TourTime)
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
        [HttpGet]
        public IActionResult Edit(int appointmentid)
        {
            ViewBag.Appointments = _appointmentContext.tourtimes.ToList();
            var appointment = _appointmentContext.responses.Single(x => x.AppointmentId == appointmentid);

            return View("Signup", appointment);
        }
        
        [HttpPost]
        public IActionResult Edit(MakeAppointment appointment)
        {
            _appointmentContext.Update(appointment);
            _appointmentContext.SaveChanges();
            return RedirectToAction("ViewAppointments");
        }

        [HttpGet]
        public IActionResult Delete(int appointmentid)
        {
            var appointment = _appointmentContext.responses.Single(x => x.AppointmentId == appointmentid);

            return View();
        }

        [HttpPost]
        public IActionResult Delete(MakeAppointment appointment)
        {
            _appointmentContext.responses.Remove(appointment);
            _appointmentContext.SaveChanges();

            return RedirectToAction("ViewAppointments");
            //return View("Index");

        }

    }
}
