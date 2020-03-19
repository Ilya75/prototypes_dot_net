using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Castle.Facilities.Logging;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace NHibernate.PrototypeOne.Console
{
    public class StartupInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IStartup>().ImplementedBy<Startup>());
            /*container.Register(AllTypes
                .FromThisAssembly()
                //.IncludeNonPublicTypes()
                .BasedOn<ISubProgram>()
                .Configure(c => c.LifeStyle.Transient.Named(c.Implementation.Name.Replace("Program", string.Empty)))
                .WithService
                .Base()); */
            //container.AddFacility<LoggingFacility>(f => f.LogUsing(LoggerImplementation.NLog).WithConfig("nlog.config"));
            container.AddFacility<LoggingFacility>(f => f.LogUsing(LoggerImplementation.NLog).WithAppConfig());
        }
    }
}
