using CadastroDeFornecedores.Models;
using System.Collections.Generic;

namespace CadastroDeFornecedores.Repositorios
{
    public class EmpresaRepositorio : BaseRepositorio<Empresa>
    {
        public EmpresaRepositorio() : base()
        {

        }

        public IList<Empresa> GetByName(string name)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                var result = session.QueryOver<Empresa>()
                    .Where(x => x.NomeFantasia == name).List();

                return result;
            }
        }
    }
}