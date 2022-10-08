using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._1_Adapter
{
    public class Logger : Ilogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log padrão - {message}"); 
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine($"Log padrão - {exception.Message}");
        }
    }
}
