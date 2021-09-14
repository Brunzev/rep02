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
    public class CompraController : Controller
    {
        public IActionResult PagaCompra(){
            return View();
        }
        public IActionResult ResumenCompra(){
            return View();
        }
    }
}