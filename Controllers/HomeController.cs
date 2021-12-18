using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuscSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MainPage()
        {
            return View();
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult RegPage()
        {
            return View();
        }
        public IActionResult NewsPage()
        {
            return View();
        }
    }
}
