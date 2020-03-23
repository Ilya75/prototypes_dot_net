using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.PrototypeOne.ClassLibrary.Entities
{
    public class BloggerData
    {
        public virtual Guid PostId { get; set; }
        public virtual string Post { get; set; }
        public virtual DateTime DatePosted { get; set; }
        public virtual string Topic { get; set; }
        public virtual Blogger Blogger { get; set; }
    }
}
