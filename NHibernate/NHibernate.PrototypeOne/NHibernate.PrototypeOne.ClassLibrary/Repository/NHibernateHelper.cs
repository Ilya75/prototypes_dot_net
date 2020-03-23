using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using NHibernate.PrototypeOne.ClassLibrary.Mapping;
using NHibernate.PrototypeOne.ClassLibrary.Repository;

namespace NHibernate.PrototypeOne.ClassLibrary.Repository
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static Configuration _configuration;

        public static Configuration Configuration
        {
            get
            {
                if (_configuration == null )
                {
                    _configuration = new Configuration()
                                            .Configure();

                    var mapper = new ModelMapper();
                    mapper.AddMappings(new List<System.Type> { typeof(BloggerMap), typeof(BloggerDataMap) });

                    _configuration.AddDeserializedMapping(mapper.CompileMappingForAllExplicitlyAddedEntities(), null);
                }
                return _configuration;
            }
        }

        public static ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = Configuration.BuildSessionFactory();
            }

            return _sessionFactory.OpenSession();
        }

    }
}
