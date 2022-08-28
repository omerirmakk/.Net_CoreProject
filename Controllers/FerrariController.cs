using Microsoft.AspNetCore.Mvc;
using OmerFarukIrmakProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmerFarukIrmakProject.Controllers
{
    public class FerrariController : Controller
    {
        public IActionResult Index()
        {
            List<CarName> lstcarname = new List<CarName>();
            lstcarname.Add(new CarName() { CarsName = "Ferrari" });
            return View(lstcarname);
        }
    }
}
