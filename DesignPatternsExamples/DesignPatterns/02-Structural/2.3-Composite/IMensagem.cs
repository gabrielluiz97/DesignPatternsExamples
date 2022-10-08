using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._3_Composite
{
    public interface IMensagem
    {
        string Descricao { get; set; }
        void ExibirMensagens(int sub);
    }
}
