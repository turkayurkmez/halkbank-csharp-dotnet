﻿using intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace intro.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Türkay";
            ViewBag.ZiyaretSaati = DateTime.Now.Hour;
            ViewBag.Cities = new List<string> { "İstanbul", "Ankara", "Hatay", "Eskişehir" };

            return View();
        }

        public IActionResult rsvp()
        {

            return View();
        }
        [HttpPost]
        public IActionResult rsvp(Visitor visitor)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", visitor);
            }
            return View();
        }
    }
}
