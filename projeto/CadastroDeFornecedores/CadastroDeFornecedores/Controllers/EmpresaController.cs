using Microsoft.AspNetCore.Mvc;

namespace CadastroDeFornecedores.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}