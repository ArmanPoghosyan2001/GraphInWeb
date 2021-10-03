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
        private CosinusBL cosinusBL = new CosinusBL();

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Sinus(int range = 1000)
        {
            Dictionary<int, float> sinePoints = sinusBL.CalculatePoints(range);
            return Json(sinePoints);
        }
        public JsonResult Cosinus(int range = 1000)
        {
            Dictionary<int, float> cosinePoints = cosinusBL.CalculatePoints(range);
            return Json(cosinePoints);
        }
    }
}
