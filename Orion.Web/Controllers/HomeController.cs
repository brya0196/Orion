﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Orion.Web.Models;

namespace Orion.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("TiposUsuarios");
        }

        public IActionResult TiposUsuarios()
        {
            return View();
        }
        
        public IActionResult AddTiposUsuarios()
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
