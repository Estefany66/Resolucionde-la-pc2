using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using piraña.Models;

namespace piraña.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Pagina: quienes somos
        public IActionResult Index()
        {
            return View();
        }

            // Pagina: Servicios y Productos
            public IActionResult Servicios()
        {
            return View();
        }
        // Pagina: fromulario de contacto
            public IActionResult Contacto()
        {
            return View();
        }
        
         // Pagina: Recibe los datos del formulario de contacto
        [HttpPost]
            public IActionResult Contacto(string datos)
        {
            return View();
        }
          // Pagina: confirmacion de la recepcion de los datos del formulario de contacto
            public IActionResult Contactoconfirmacion()
        {
            return View();
        }
          
    }
}
