using Castle.Core.Logging;
using Castle.MicroKernel;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.PrototypeOne.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var container = new WindsorContainer())
            {
                try
                {
                    // install all installers within this assembly
                    container.Install(new StartupInstaller());
                    //var startup = container.Resolve<IStartup>(args[0]);
                    var startup = container.Resolve<IStartup>();
                    startup.Run();
                    System.Console.ReadKey();
                }
                catch (ComponentNotFoundException ex)
                {
                    Usage(container, ex);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Usage(container, ex);
                }
            }
        }

        private static void Usage(WindsorContainer container, Exception ex)
        {
            var q = from c in container.ResolveAll<IStartup>()
                    select c.GetType().Name.Replace("Program", string.Empty);

            System.Console.WriteLine("Usage: Program {0}", string.Join("|", q));
            var logger = container.Resolve<ILogger>();
            logger.Fatal(ex.GetType().ToString(), ex);
            logger.Error(ex.GetType().ToString(), ex);
            logger.Warn(ex.GetType().ToString(), ex);
            logger.Info(ex.GetType().ToString(), ex);
            logger.Debug(ex.GetType().ToString(), ex);

            System.Console.ReadLine();
        }
    }
}
