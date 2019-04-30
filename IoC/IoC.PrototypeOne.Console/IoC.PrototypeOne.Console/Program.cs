using Castle.Windsor;
using IoC.PrototypeOne.ClassLibrary;
using IoC.PrototypeOne.Console.Installers;
using System;

namespace IoC.PrototypeOne.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Install(new WindsorInstaller());

            var calc = container.Resolve<ICalculator<double>>();
            var sum = calc.Add(2, 3);

            System.Console.WriteLine($" 2 + 3 is {sum}");
            System.Console.ReadKey();
        }
    }
}
