
using CadastroDeFornecedores.Models;
using CadastroDeFornecedores.Repositorios;

namespace CadastroDeFornecedores.Servicos
{
    public class ServicoTelefone
    {
        private TelefoneRepositorio _telefoneRepositorio;
        private FornecedorRepositorio _fornecedorRepositorio;


        public ServicoTelefone(TelefoneRepositorio telefoneRepositorio, FornecedorRepositorio fornecedorRepositorio)
        {
            _telefoneRepositorio = telefoneRepositorio;
            _fornecedorRepositorio = fornecedorRepositorio;
        }

        public string Cadastrar(string idFornecedor, string numero)
        {
            var fornecedor = new Telefone()
            {
                Numero = numero,
                Fornecedor = _fornecedorRepositorio.GetById(idFornecedor)
            };
            return _telefoneRepositorio.Insert(fornecedor);
        }
    }
}
