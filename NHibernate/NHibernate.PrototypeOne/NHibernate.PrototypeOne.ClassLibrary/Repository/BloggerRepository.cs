using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using NHibernate.PrototypeOne.ClassLibrary.Entities;
using NHibernate.PrototypeOne.ClassLibrary.Mapping;
using NHibernate.PrototypeOne.Console.Interfaces;

namespace NHibernate.PrototypeOne.ClassLibrary.Repository
{
    public class BloggerRepository : IBloggerRepository
    {
        public void Delete(Blogger blogger)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(blogger);
                transaction.Commit();
            }
        }

        public Blogger Get(Guid id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Blogger>(id);
        }

        public long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.QueryOver<Blogger>().RowCountInt64();
        }

        public void Save(Blogger blogger)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(blogger);
                transaction.Commit();
            }
        }

        public void Update(Blogger blogger)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(blogger);
                transaction.Commit();
            }
        }
    }
}
