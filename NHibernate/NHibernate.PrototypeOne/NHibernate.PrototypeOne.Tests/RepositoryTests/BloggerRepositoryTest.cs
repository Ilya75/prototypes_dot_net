using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.PrototypeOne.Console.Interfaces;
using NHibernate.PrototypeOne.ClassLibrary.Repository;
using NHibernate.Tool.hbm2ddl;
using Xunit;
using NHibernate.PrototypeOne.ClassLibrary.Entities;
using System.IO;

namespace NHibernate.PrototypeOne.Tests.RepositoryTests
{
    public class BloggerRepositoryTest
    {
        private IBloggerRepository _bloggerRepository;

        public BloggerRepositoryTest()
        {
            DeleteExistingDatabase();
            var schemaUpdate = new SchemaUpdate(NHibernateHelper.Configuration);
            schemaUpdate.Execute(false, true);

            _bloggerRepository = new BloggerRepository();
        }

        [Fact]
        public void CanSaveBlogger()
        {
            // Arrange & Act
            _bloggerRepository.Save(new Blogger { Name = "Test Blogger", Rank = 0, Url = "http://test.org" });

            // Assert
            Assert.Equal(1, _bloggerRepository.RowCount());
        }

        [Fact]
        public void CanGetBlogger()
        {
            // Arrange & Act
            var blogger = new Blogger { Name = "Bob", Rank = 0, Url = "http://bob.org" };
            _bloggerRepository.Save(blogger);

            // Assert
            var result = _bloggerRepository.Get(blogger.BloggerId);
            Assert.NotNull(result);
        }

        [Fact]
        public void CanUpdateBlogger()
        {
            // Arrange
            var blogger = new Blogger { Name = "Greg", Rank = 0, Url = "http://greg.org" };
            _bloggerRepository.Save(blogger);

            // Act
            var newName = "Gregory";
            blogger = _bloggerRepository.Get(blogger.BloggerId);

            blogger.Name = newName;
            _bloggerRepository.Update(blogger);

            // Assert
            Assert.Equal(newName, _bloggerRepository.Get(blogger.BloggerId).Name);
        }

        [Fact]
        public void CanDeleteBlogger()
        {
            // Arrange
            var blogger = new Blogger { Name = "Michael", Rank = 0, Url = "http://Michael.org" };

            // Act
            _bloggerRepository.Save(blogger);
            _bloggerRepository.Delete(blogger);

            var result = _bloggerRepository.Get(blogger.BloggerId);

            // Assert
            Assert.Equal(null, result);

        }

        private void DeleteExistingDatabase()
        {
            if (File.Exists("test.db"))
                File.Delete("test.db");
        }
    }
}
