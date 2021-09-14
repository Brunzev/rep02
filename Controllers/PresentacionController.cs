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
    public class PresentacionController : Controller
    {
        public IActionResult QuienesSomos(){
            return View();
        }
        public IActionResult ServicioProducto(){
            return View();
        }
        public IActionResult FormularioContacto(){
            return View();
        }
    }
}