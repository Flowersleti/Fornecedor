using CadastroDeFornecedores.Models;
using CadastroDeFornecedores.Repositorios;
using System;

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

        public string Cadastrar(string idEmpresa, string nome, string cpfcnpj)
        {
            var empresa = _empresaRepositorio.GetById(idEmpresa);
            if (empresa.UF == "PR")
            {

            }

            var fornecedor = new Fornecedor()
            {
                Nome = nome,
                CPFCNPJ = cpfcnpj,
                Cadastro = DateTime.Now,
                Empresa = empresa
            };
            return _fornecedorRepositorio.Insert(fornecedor);
        }

        public bool VerificarIdade()
        {
            return true;
        }
    }
}