using Microsoft.AspNetCore.Mvc;

namespace CadastroDeFornecedores.Controllers
{
    public class FornecedorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}