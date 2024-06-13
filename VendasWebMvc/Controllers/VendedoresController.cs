using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Data;

namespace VendasWebMvc.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendasWebMvcContext _context;

        public VendedoresController(VendasWebMvcContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
