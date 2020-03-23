using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.PrototypeOne.ClassLibrary.Entities;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace NHibernate.PrototypeOne.ClassLibrary.Mapping
{
    public class BloggerMap : ClassMapping<Blogger>
    {
        public BloggerMap()
        {
            Id(x => x.BloggerId, m => m.Generator(Generators.GuidComb));
            Property(x => x.Name);
            Property(x => x.Url);
            Property(x => x.Rank);
            List(x => x.Posts, x =>
            {
                x.Key(k => k.Column("PostId"));
                x.Index(i => i.Column("DateCreated"));
                x.Cascade(Cascade.All | Cascade.DeleteOrphans);
            }, x => x.OneToMany()
            );
        }
    }
}
