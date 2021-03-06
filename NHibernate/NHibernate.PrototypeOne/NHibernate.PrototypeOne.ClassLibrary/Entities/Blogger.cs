﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.PrototypeOne.ClassLibrary.Entities
{
    public class Blogger
    {
        public virtual Guid BloggerId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
        public virtual int Rank { get; set; }
        public virtual IList<BloggerData> Posts { get; set; }
    }
}
