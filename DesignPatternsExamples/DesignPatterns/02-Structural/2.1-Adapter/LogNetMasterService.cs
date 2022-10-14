using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._1_Adapter
{
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            {
                Console.WriteLine($"Log Customizado - {message}");
            }
        }
        public void LogError(Exception exception)
        {
            Console.WriteLine($"Log Customizado - {exception.Message}");
        }

    }
}
