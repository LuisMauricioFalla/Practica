using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PM___PRACTICA___Mauricio_Falla.Models;

namespace PM___PRACTICA___Mauricio_Falla.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.usuario = HttpContext.Session.GetString("Usuario");
            var gp = new GestorProductos();
            return View(gp.Listado());
        }
        
        public IActionResult Producto()
        {
            var gp = new GestorProductos();
            return View(gp.Listado());
        }
    }
}