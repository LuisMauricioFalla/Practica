using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PM___PRACTICA___Mauricio_Falla.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult RegistroSesion(){
            return View();
        }
        [HttpPost]
        public IActionResult RegistroSesion(string nombre, string correo){
            TempData["nombre"] = nombre;
            TempData["correo"] = correo;
            return RedirectToAction("ConfirmarRegistro");
        }

        public IActionResult ConfirmarRegistro(){
            return View();
        }

        public IActionResult InicioSesion(){
            return View();
        }

        [HttpPost]
        public IActionResult InicioSesion( string c, string p){
            if(c=="admin@admin.com" && p=="123456")
            {
                HttpContext.Session.SetString("usuario", c);
                return RedirectToAction("Index","Home");
            }
            ViewBag.error = "Datos Incorrectos";
            return View();
        }

        public IActionResult Contacto(){
            return View();
        }

        public IActionResult ConfirmarContacto(){
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmarContacto(string c, string t, string d){
            TempData["correo"] = c;
            TempData["titulo"] = t;
            TempData["texto"] = d;
            return RedirectToAction("ConfirmarContacto");
        }
    }
}