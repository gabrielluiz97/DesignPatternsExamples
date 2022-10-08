using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Behavoral._3._1_Command
{
    internal abstract class Commander
    {
        public abstract void Executar();
        public abstract void Desfazer();
    }
}
