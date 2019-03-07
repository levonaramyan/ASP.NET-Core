using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_01_Planets.Models;

namespace MVC_01_Planets.Controllers
{
    public class PlanetsController : Controller
    {
        public IActionResult PlanetList()
        {
            List<Planet> planets = new List<Planet>()
            {
                new Planet(){ Name = "Mercury",Description = "This is the 1st planet in the Solar system"},
                new Planet(){ Name = "Venus",Description = "This is the 2nd planet in the Solar system"},
                new Planet(){ Name = "Earth",Description = "This is the 3rd planet in the Solar system"},
                new Planet(){ Name = "Mars",Description = "This is the 4th planet in the Solar system"},
                new Planet(){ Name = "Jupiter",Description = "This is the 5th planet in the Solar system"},
                new Planet(){ Name = "Saturn",Description = "This is the 6th planet in the Solar system"},
                new Planet(){ Name = "Uranus",Description = "This is the 7th planet in the Solar system"},
                new Planet(){ Name = "Neptune",Description = "This is the 8th planet in the Solar system"},
            };

            return View(planets);
        }
    }
}