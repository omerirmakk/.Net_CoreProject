using Microsoft.AspNetCore.Mvc;
using OmerFarukIrmakProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmerFarukIrmakProject.Controllers
{
    public class BmwController : Controller
    {
        

        public IActionResult Index()
        {
            List<CarPrice> lstcar = new List<CarPrice>();
            lstcar.Add(new CarPrice() { CarsMade=2014, CarsModel= 3, CarsPrice=45400 });
            
            
            return View(lstcar);
            
        }
    }
}
