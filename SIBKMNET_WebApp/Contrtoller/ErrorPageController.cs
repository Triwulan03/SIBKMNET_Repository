using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKMNET_WebApp.Contrtoller
{
    public class ErrorPageController : Controller
    {
        public IActionResult Unauthorized()
        {

            return View();
        }
    }
}
