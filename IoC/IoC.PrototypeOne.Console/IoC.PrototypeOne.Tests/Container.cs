using Castle.Windsor;
using IoC.PrototypeOne.Tests.Installers;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoC.PrototypeOne.Tests
{
    public class Container
    {
        private static WindsorContainer _container;

        public static WindsorContainer Instance
        {
            get
            {
                if (_container == null)
                {
                    _container = new WindsorContainer();
                    _container.Install(new WindsorInstaller());
                }

                return _container;
            }
        }
    }
}
