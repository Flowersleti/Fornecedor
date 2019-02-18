using CadastroDeFornecedores.Models;
using FluentNHibernate.Mapping;

namespace CadastroDeFornecedores.Hibernate
{
    public class FornecedorMap : ClassMap<Fornecedor>
    {
        public FornecedorMap()
        {
            Table("FORNECEDOR");
            Id(x => x.Id);
            Map(x => x.Nome);
            Map(x => x.CPFCNPJ);
            Map(x => x.Cadastro);
            References(x => x.Empresa, "Empresa").Not.LazyLoad();
        }
    }
}