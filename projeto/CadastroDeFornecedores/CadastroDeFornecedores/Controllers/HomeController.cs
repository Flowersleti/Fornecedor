using Microsoft.AspNetCore.Mvc;

namespace CadastroDeFornecedores.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}