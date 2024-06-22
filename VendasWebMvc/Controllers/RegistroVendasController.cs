using Microsoft.AspNetCore.Mvc;

namespace VendasWebMvc.Controllers
{
    public class RegistroVendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SimpleSearch()
        {
            return View();
        }
        public IActionResult GropingSearch()
        {
            return View();
        }
    }
}
