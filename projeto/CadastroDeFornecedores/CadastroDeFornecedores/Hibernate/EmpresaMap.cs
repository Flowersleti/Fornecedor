using CadastroDeFornecedores.Models;
using FluentNHibernate.Mapping;

namespace CadastroDeFornecedores.Hibernate
{
    public class EmpresaMap : ClassMap<Empresa>
    {
        public EmpresaMap()
        {
            Table("EMPRESA");
            Id(x => x.Id);
            Map(x => x.UF);
            Map(x => x.NomeFantasia);
            Map(x => x.CNPJ);
        }
    }
}