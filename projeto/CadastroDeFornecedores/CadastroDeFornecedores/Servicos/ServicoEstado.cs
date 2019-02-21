using CadastroDeFornecedores.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeFornecedores.Servicos
{
    public class ServicoEstado
    {
        EstadoRepositorio _estadoRepositorio;

        public ServicoEstado(EstadoRepositorio estadoRepositorio)
        {
            _estadoRepositorio = estadoRepositorio;
        }

        public List<string> BuscarTodosOsEstados()
        {
            return _estadoRepositorio.GetAllEstados();
        }
    }
}
