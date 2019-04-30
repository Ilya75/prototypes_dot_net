using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using IoC.PrototypeOne.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.PrototypeOne.Console.Installers
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For(typeof(ICalculator<>))
                .ImplementedBy(typeof(Calculator<>))
                .LifestyleTransient());
        }
    }
}
