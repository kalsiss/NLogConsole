using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int zero = 0;
                int result = 5 / zero;
            }
            catch (DivideByZeroException ex)
            {
                // get a Logger object and log exception here using NLog
                // this will use our default logger, because we named it '*' in the NLog.config file
                Logger logger = LogManager.GetCurrentClassLogger();
                // add custom message and pass in the exception
              //  logger.Error("Whoops!", ex);
                logger.Error(ex, "Whoops");
            }
        }
    }
}
