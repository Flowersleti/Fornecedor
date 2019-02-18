using CadastroDeFornecedores.Models;
using CadastroDeFornecedores.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroDeFornecedores.Controllers
{
    public class EmpresaController : Controller
    {
        private ServicoEmpresa _servicoEmpresa;

        public EmpresaController()
        {
            _servicoEmpresa = ControleDeInjecao.ServicoEmpresa;
        }

        public IActionResult Index()
        {
            List<Empresa> empresas = _servicoEmpresa.PegarTodos();
            return View(empresas);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new Empresa());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Empresa empresa)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(string id)
        {
            Empresa empresa = _servicoEmpresa.PegarPorId(id);
            return View("Cadastrar", empresa);
        }

        [HttpPost]
        public IActionResult Editar([FromForm]Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _servicoEmpresa.Editar(empresa);
                return RedirectToAction("Index");
            }
            return View("Cadastrar", empresa);
        }

        [HttpGet]
        public IActionResult Excluir(string id)
        {
            _servicoEmpresa.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}