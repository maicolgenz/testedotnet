using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testedotnet.Models;

namespace testedotnet.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
