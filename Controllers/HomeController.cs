using System;
using System.Collections.Generic;//Lista de colecciones genericas
using System.Diagnostics;
using System.Linq; //Para hacer macth entre lista del dataReader y los antributos del modelo (usuario y contrasena)
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoFinal_SistemaVentas.Models;
//using Microsoft.AspNetCore.Http;//Para el manejo de solicitudes y respuestas HTTP
//using System.Data;//Identificar el tipo de objeto a manipular en base de datos

//using Microsoft.Data.SqlClient;//Controlador de acceso a datos
namespace ProyectoFinal_SistemaVentas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()  {
            //regresar una Vista con un Modelo
           
            Models.Login logueate= new Models.Login() {
              
                idrol = 1,
                email ="flor",
                password="123"
            };
            return View(logueate);
        }
/*
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
*/



        
    }
}
