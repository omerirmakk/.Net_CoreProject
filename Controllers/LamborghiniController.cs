using Microsoft.AspNetCore.Mvc;
using OmerFarukIrmakProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmerFarukIrmakProject.Controllers
{
    public class LamborghiniController : Controller
    {
        public IActionResult Index()
        {
            List<CarPrice> lstcar = new List<CarPrice>();
            lstcar.Add(new CarPrice() {CarsMade = 2009, CarsModel = 911, CarsPrice=125000 });
            return View(lstcar);
        }
    }
}
