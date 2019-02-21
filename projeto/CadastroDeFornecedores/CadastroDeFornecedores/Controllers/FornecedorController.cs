using CadastroDeFornecedores.Models;
using CadastroDeFornecedores.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroDeFornecedores.Controllers
{
    public class FornecedorController : Controller
    {
        private ServicoFornecedor _servicoFornecedor;
        private ServicoEmpresa _servicoEmpresa;
        private string _idEmpresa;

        public FornecedorController()
        {
            _servicoFornecedor = ControleDeInjecao.ServicoFornecedor;
            _servicoEmpresa = ControleDeInjecao.ServicoEmpresa;
        }
        public IActionResult Index(string id)
        {
            _idEmpresa = id;
            ViewBag.Empresa = _servicoEmpresa.PegarPorId(id);
            List<Fornecedor> fornecedor = _servicoFornecedor.PegarTodos();
            return View(fornecedor);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new Fornecedor());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _servicoFornecedor.Cadastrar(fornecedor);
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        [HttpGet]
        public IActionResult Editar(string id)
        {
            Fornecedor fornecedor = _servicoFornecedor.PegarPorId(id);
            return View("Cadastrar", fornecedor);
        }

        [HttpPost]
        public IActionResult Editar([FromForm]Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _servicoFornecedor.Editar(fornecedor);
                return RedirectToAction("Index");
            }
            return View("Cadastrar", fornecedor);
        }

        [HttpGet]
        public IActionResult Excluir(string id)
        {
            _servicoFornecedor.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}