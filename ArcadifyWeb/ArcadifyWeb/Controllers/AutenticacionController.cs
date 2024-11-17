using Microsoft.AspNetCore.Mvc;

namespace ArcadifyWeb.Controllers
{
    public class AutenticacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult RegistrarAdmin()
        {
            return View();
        }

        public IActionResult Ingresar()
        {
            return View();
        }

        public IActionResult RecuperarContrasena()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NotFound404()
        {
            return View();
        }
    }
}
