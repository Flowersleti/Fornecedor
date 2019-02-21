using CadastroDeFornecedores.Models;
using CadastroDeFornecedores.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroDeFornecedores.Controllers
{
    public class EmpresaController : Controller
    {
        private ServicoEmpresa _servicoEmpresa;
        private ServicoEstado _servicoEstado;
        private List<string> _estados;

        public EmpresaController()
        {
            _servicoEmpresa = ControleDeInjecao.ServicoEmpresa;
            _servicoEstado = ControleDeInjecao.ServicoEstado;
            _estados = _servicoEstado.BuscarTodosOsEstados();
        }

        public IActionResult Index()
        {
            List<Empresa> empresas = _servicoEmpresa.PegarTodos();
            return View(empresas);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Estados = _estados;
            return View(new Empresa());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _servicoEmpresa.Cadastrar(empresa);
                return RedirectToAction("Index");
            }
            ViewBag.Estados = _estados;
            return View(empresa);
        }

        [HttpGet]
        public IActionResult Editar(string id)
        {
            Empresa empresa = _servicoEmpresa.PegarPorId(id);
            ViewBag.Estados = _estados;
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
            ViewBag.Estados = _estados;
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