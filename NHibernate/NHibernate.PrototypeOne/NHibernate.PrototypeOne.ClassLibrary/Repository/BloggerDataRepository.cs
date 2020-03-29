using NHibernate.PrototypeOne.ClassLibrary.Entities;
using NHibernate.PrototypeOne.ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.PrototypeOne.ClassLibrary.Repository
{
    public class BloggerDataRepository : IBloggerDataRepository
    {
        public void Delete(BloggerData data)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(data);
                transaction.Commit();
            }
        }

        public BloggerData Get(Guid id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<BloggerData>(id);
        }

        public long RowCount()
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.QueryOver<Blogger>().RowCountInt64();
        }

        public void Save(BloggerData data)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(data);
                transaction.Commit();
            }
        }

        public void Update(BloggerData data)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(data);
                transaction.Commit();
            }
        }
    }
}
