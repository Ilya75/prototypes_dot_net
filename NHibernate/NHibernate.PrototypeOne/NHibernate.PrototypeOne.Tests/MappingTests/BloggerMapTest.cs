using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xunit;
using NHibernate.Mapping.ByCode;
using NHibernate.PrototypeOne.ClassLibrary.Mapping;

namespace NHibernate.PrototypeOne.Tests.MappingTests
{
    public class BloggerMapTest
    {
        [Fact]
        public void Can_Generate_Blogger_XmlMapping()
        {
            // Arrange
            var result = "";
            var mapper = new ModelMapper();
            mapper.AddMapping<BloggerMap>();

            // Act
            var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
            result = mapping.AsString();
                                
            // Assert
            Assert.NotEqual("", result);
        }
    }
}
