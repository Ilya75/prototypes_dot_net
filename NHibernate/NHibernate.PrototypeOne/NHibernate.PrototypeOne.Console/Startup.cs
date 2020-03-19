using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.PrototypeOne.Console
{
    public class Startup : IStartup
    {
        private ILogger _logger = NullLogger.Instance;

        public ILogger Logger
        {
            get
            {
                return _logger;
            }
            set
            {
                _logger = value;
            }
        }

        public void Run()
        {
            Logger.Debug("Executing run() method...");
        }
    }
}
