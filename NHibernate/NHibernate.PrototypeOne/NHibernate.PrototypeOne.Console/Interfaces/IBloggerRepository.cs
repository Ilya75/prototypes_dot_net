using NHibernate.PrototypeOne.ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.PrototypeOne.Console.Interfaces
{
    public interface IBloggerRepository
    {
        Blogger Get(Guid id);
        void Save(Blogger blogger);
        void Update(Blogger blogger);
        void Delete(Blogger blogger);
        long RowCount();
    }
}
