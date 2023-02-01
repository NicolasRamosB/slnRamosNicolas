using Microsoft.AspNetCore.Mvc;

namespace SistemaWebRecetas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
