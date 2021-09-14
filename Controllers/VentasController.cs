using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rep02.Models;

namespace rep02.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult CatalogoCompleto(){
            return View();
        }
        public IActionResult ProductoDestacado(){
            return View();
        }
        public IActionResult Servicios(){
            return View();
        }
    }
}