using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleMVC.Controllers
{
    public class TrystinController : Controller
    {
        public IActionResult Bio()
        {
            return View();
        }
    }
}