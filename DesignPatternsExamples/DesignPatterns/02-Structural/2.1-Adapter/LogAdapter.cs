using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._1_Adapter
{
    public class LogAdapter : Ilogger
    {
        private readonly ILogNetMaster _logNetMaster;

        public LogAdapter(ILogNetMaster logNetMaster)
        {
            _logNetMaster = logNetMaster;
        }

        public void Log(string message)
        {
            _logNetMaster.LogInfo(message);
        }

        public void LogError(Exception exception)
        {
            _logNetMaster.LogError(exception);
        }
    }
}
