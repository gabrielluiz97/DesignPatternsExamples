using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._1_Adapter
{
    public interface ILogNetMaster
    {
        void LogInfo(string message);
        void LogError(Exception exception);
    }
}
