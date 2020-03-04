using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WareHouse_Storage_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Normal()
        {
            return View();
        }

        public IActionResult Picture()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Items()
        {
            return View();
        }

        public IActionResult Location()
        {
            return View();
        }
    }
}
