using Microsoft.AspNetCore.Mvc;

namespace piraña.Controllers
{
    public class VentasController: Controller
    
    {
            // Servicios
            public IActionResult Servicios()
        {
            return View();
        }

           // Productos
            public IActionResult Producos()
        {
            return View();
        }
          //Productos destacados
            public IActionResult Productosdestacados()
        {
            return View();
        }
    }
}