using BL;
using FirstTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTask.Controllers
{
    public class HomeController : Controller
    {
        private SinusBL sinusBL = new SinusBL();
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Sinus(int range = 1000)
        {
            Dictionary<int, float> sinePoints = sinusBL.CalculatePoints(range); 
            return Json(sinePoints);
            //return View(sinePoints);
        }
    }
}
