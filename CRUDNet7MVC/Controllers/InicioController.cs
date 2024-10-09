using CRUDNet7MVC.Models;
using CRUDNet7MVC.Datos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace CRUDNet7MVC.Controllers
{
    public class InicioController : Controller
    {
        private readonly AplicationDbContex _contexto;

        public InicioController(AplicationDbContex contexto)
        {
            _contexto = contexto;

        }
        [HttpGet]

        public async Task<ActionResult> Index()
        {
            return View(await _contexto.Contacto.ToListAsync());
        }

        /*public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
