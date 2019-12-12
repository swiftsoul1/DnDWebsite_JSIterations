using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DnDWebsite_JSPart.Models;

namespace DnDWebsite_JSPart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View(new Encounter());
        }
        [HttpPost]
        public IActionResult Index(Encounter result)
        {
            result.ReadEncounter();
            return View("EncountDetails", result);
        }

        public IActionResult EncountDetails(Encounter result)
        {
            //set up initative order here
            return View(result);
        }

        public IActionResult Chat()
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
