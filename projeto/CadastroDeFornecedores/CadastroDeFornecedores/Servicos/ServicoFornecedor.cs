using CadastroDeFornecedores.Models;
using CadastroDeFornecedores.Repositorios;
using System;
using System.Collections.Generic;

namespace CadastroDeFornecedores.Servicos
{
    public class ServicoFornecedor
    {
        private FornecedorRepositorio _fornecedorRepositorio;
        private EmpresaRepositorio _empresaRepositorio;

        public ServicoFornecedor(FornecedorRepositorio fornecedorRepositorio, EmpresaRepositorio empresaRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
            _empresaRepositorio = empresaRepositorio;
        }

        public string Cadastrar(Fornecedor fornecedor)
        {
            var empresa = _empresaRepositorio.GetById(fornecedor.Empresa.Id);
            if (empresa.UF == "PR")
            {

            }
            fornecedor.Cadastro = DateTime.Now;
            
            return _fornecedorRepositorio.Insert(fornecedor);
        }

        public bool VerificarIdade()
        {
            return true;
        }

        public Fornecedor PegarPorId(string id)
        {
            return _fornecedorRepositorio.GetById(id);
        }

        public void Editar(Fornecedor fornecedor)
        {
            _fornecedorRepositorio.Update(fornecedor);
        }

        public void Excluir(string id)
        {
            var fornecedor = _fornecedorRepositorio.GetById(id);
            _fornecedorRepositorio.Delete(fornecedor);
        }

        public List<Fornecedor> PegarTodos()
        {
            return _fornecedorRepositorio.GetAll();
        }
    }
}