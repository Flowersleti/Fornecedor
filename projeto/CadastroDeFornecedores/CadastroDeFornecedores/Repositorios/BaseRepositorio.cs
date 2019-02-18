using NHibernate;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeFornecedores.Repositorios
{
    public class BaseRepositorio<T>
    {
        protected ISessionFactory _sessionFactory;

        public BaseRepositorio()
        {
            _sessionFactory = NHibernateConfig.NHIBERNATE_CONFIGURATION.BuildSessionFactory();

        }

        public string Insert(T x)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                var id = session.Save(x);
                session.Flush();
                return id.ToString();
            }
        }

        public T GetById(string id)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                return session.Get<T>(id);
            }
        }

        public void Delete(T x)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                session.Delete(x);
                session.Flush();
            }
        }

        public void Update(T x)
        {
            using (var session = _sessionFactory.OpenSession())
            {
                session.Update(x);
                session.Flush();
            }
        }

        public List<T> GetAll()
        {
            using (var session = _sessionFactory.OpenSession())
            {
                return session.Query<T>().ToList();
            }
        }
    }
}