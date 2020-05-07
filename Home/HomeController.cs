using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqrRootComparator.Models;

namespace SqrRootComparator
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Sqrt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sqrt(string firstnumber, string secondnumber)
        {
            int Number1 = Convert.ToInt16(firstnumber);
            double SqrtNumber1 = Math.Sqrt(Number1);
            int Number2 = Convert.ToInt16(secondnumber);
            double SqrtNumber2 = Math.Sqrt(Number2);
            ViewBag.Result1 = SqrtNumber1;
            ViewBag.Result2 = SqrtNumber2;
            ViewBag.Result3 = Number1;
            ViewBag.Result4 = Number2;
            return View();
        }

        public IActionResult Privacy()
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
