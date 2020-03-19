using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NHibernate.Tool.hbm2ddl;
using NHibernate.PrototypeOne.Console.Repository;

namespace NHibernate.PrototypeOne.Tests.RepositoryTests
{
    public class SchemaTest
    {
        [Fact]
        public void CanGenerateSchema()
        {
            var schemaUpdate = new SchemaUpdate(NHibernateHelper.Configuration);
            schemaUpdate.Execute(true, true);
        }
    }
}
