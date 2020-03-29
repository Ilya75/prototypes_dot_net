using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.PrototypeOne.ClassLibrary.Entities;

namespace NHibernate.PrototypeOne.ClassLibrary.Mapping
{
    public class BloggerDataMap : ClassMapping<BloggerData>
    {
        public BloggerDataMap()
        {
            Id(x => x.PostId, m => m.Generator(Generators.GuidComb));
            Property(x => x.Post);
            Property(x => x.DatePosted);
            Property(x => x.Topic);
            ManyToOne(x => x.Blogger, x =>
            {
                x.Column("BloggerId");
                x.Cascade(Cascade.None);
                x.ForeignKey("BloggerId");
            });
        }
    }
}
