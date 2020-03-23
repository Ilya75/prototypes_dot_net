using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NHibernate.Tool.hbm2ddl;
using NHibernate.PrototypeOne.ClassLibrary.Repository;

namespace NHibernate.PrototypeOne.Tests.RepositoryTests
{
    public class SchemaTest
    {
        //[Fact(Skip ="Used only for manual tests")]
        [Fact]
        public void CanGenerateSchema()
        {
            var schemaUpdate = new SchemaUpdate(NHibernateHelper.Configuration);
            schemaUpdate.Execute(true, true);
        }

        [Fact]
        public void CanGenerateScript()
        {
            var schemaExport = new SchemaExport(NHibernateHelper.Configuration);
            schemaExport.SetOutputFile("testDb.sql").Execute(false, false, false);
        }
    }
}
