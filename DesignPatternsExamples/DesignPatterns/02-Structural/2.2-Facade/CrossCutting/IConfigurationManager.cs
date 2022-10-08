using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._2_Facade.CrossCutting
{
    public interface IConfigurationManager
    {
        string GetValue(string message);
    }
}
