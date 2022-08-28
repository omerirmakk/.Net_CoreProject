using Microsoft.AspNetCore.Mvc;
using OmerFarukIrmakProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmerFarukIrmakProject.Controllers
{
    public class MercedesController : Controller
    {
        public IActionResult Index()
        {
            List<CarPrice> lstcar = new List<CarPrice>();
            lstcar.Add(new CarPrice() {CarsMade = 2020, CarsModel= 250, CarsPrice = 50450 });
            return View(lstcar);
        }
    }
}
