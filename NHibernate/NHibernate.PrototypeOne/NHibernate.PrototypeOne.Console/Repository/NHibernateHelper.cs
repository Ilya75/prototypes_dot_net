using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using NHibernate.PrototypeOne.ClassLibrary.Mapping;

namespace NHibernate.PrototypeOne.Console.Repository
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static Configuration _configuration;

        public NHibernateHelper()
        {
            //_configuration = new Configuration()
            //    .Configure();

            //var mapper = new ModelMapper();
            //mapper.AddMappings(new List<System.Type> { typeof(BloggerMap) });

            //_configuration.AddDeserializedMapping(mapper.CompileMappingForAllExplicitlyAddedEntities(), null);
            //_sessionFactory = _configuration.BuildSessionFactory();
        }


        public static ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                _configuration = new Configuration()
                    .Configure();

                var mapper = new ModelMapper();
                mapper.AddMappings(new List<System.Type> { typeof(BloggerMap) });

                _configuration.AddDeserializedMapping(mapper.CompileMappingForAllExplicitlyAddedEntities(), null);
                _sessionFactory = _configuration.BuildSessionFactory();
            }

            return _sessionFactory.OpenSession();
        }

    }
}
