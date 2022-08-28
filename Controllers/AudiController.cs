using Microsoft.AspNetCore.Mvc;
using OmerFarukIrmakProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmerFarukIrmakProject.Controllers
{
    public class AudiController : Controller
    {
        public IActionResult Index()
        {
            List<CarName> lstcarname = new List<CarName>();
            lstcarname.Add(new CarName() { CarsName = "Audi" });
            return View(lstcarname);
        }
    }
}
