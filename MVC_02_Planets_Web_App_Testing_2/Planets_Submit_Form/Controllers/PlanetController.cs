using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Planets_Submit_Form.Models;

namespace Planets_Submit_Form.Controllers
{
    public class PlanetController : Controller
    {
        public IActionResult SubmitPlanets(Planet[] planets)
        {
            return View(planets);
        }
    }
}