using CadastroDeFornecedores.Models;
using FluentNHibernate.Mapping;

namespace CadastroDeFornecedores.Hibernate
{
    public class TelefoneMap : ClassMap<Telefone>
    {
        public TelefoneMap()
        {
            Table("TELEFONE");
            Id(x => x.Id);
            Map(x => x.Numero);
            References(x => x.Fornecedor, "Fornecedor").Not.LazyLoad();
        }
    }
}
