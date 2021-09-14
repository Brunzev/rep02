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
    public class CuentaController : Controller
    {
        public IActionResult ActualizarPerfil(){
            return View();
        }
        public IActionResult IniciarSesion(){
            return View();
        }
        public IActionResult Registro(){
            return View();
        }
    }
}