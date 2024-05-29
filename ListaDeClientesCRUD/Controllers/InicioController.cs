using Microsoft.AspNetCore.Mvc;

namespace ListaDeClientesCRUD.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ShowNavbar = false;
            return View("Inicio");
        }
        public IActionResult Login()
        {
            ViewBag.ShowNavbar = false;
            return View();
        }

    }
}
