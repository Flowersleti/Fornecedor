using CadastroDeFornecedores.Hibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.IO;

namespace CadastroDeFornecedores.Repositorios
{
    public class NHibernateConfig
    {
        public static NHibernate.Cfg.Configuration NHIBERNATE_CONFIGURATION;

        public static void IniciarNHibernate()
        {
            if (!Directory.Exists("C:\\temp"))
            {
                Directory.CreateDirectory("C:\\temp");
            }
            FluentConfiguration dbConfig = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile("C:\\temp\\Cadastro.db"));


            NHIBERNATE_CONFIGURATION =
            dbConfig.Mappings(x => x.FluentMappings.AddFromAssemblyOf<EmpresaMap>())
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<FornecedorMap>())
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<TelefoneMap>())
                .BuildConfiguration();
        }
    }
}