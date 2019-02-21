using CadastroDeFornecedores.Models;
using CadastroDeFornecedores.Repositorios;
using System.Collections.Generic;

namespace CadastroDeFornecedores.Servicos
{
    public class ServicoEmpresa
    {
        private EmpresaRepositorio _empresaRepositorio;
        private EstadoRepositorio _estadosRepositorio;

        public ServicoEmpresa(EmpresaRepositorio empresaRepositorio, EstadoRepositorio estadosRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
            _estadosRepositorio = estadosRepositorio;
        }

        public string Cadastrar(Empresa empresa)
        {
            return _empresaRepositorio.Insert(empresa);
        }

        public List<Empresa> PegarTodos()
        {
            return _empresaRepositorio.GetAll();
        }

        public Empresa PegarPorId(string id)
        {
            return _empresaRepositorio.GetById(id);
        }

        public void Excluir(string id)
        {
            var empresa = _empresaRepositorio.GetById(id);
            _empresaRepositorio.Delete(empresa);
        }

        public void Editar(Empresa empresa)
        {
            _empresaRepositorio.Update(empresa);
        }
    }
}