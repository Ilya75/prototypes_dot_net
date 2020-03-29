using NHibernate.PrototypeOne.ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.PrototypeOne.ClassLibrary.Interfaces
{
    public interface IBloggerDataRepository
    {
        BloggerData Get(Guid bloggerId);
        void Save(BloggerData data);
        void Update(BloggerData data);
        void Delete(BloggerData data);
        long RowCount();
    }
}
