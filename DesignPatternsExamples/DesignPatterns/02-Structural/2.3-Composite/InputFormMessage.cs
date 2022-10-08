using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._3_Composite
{
    public class InputFormMessage :IMensagem
    {
        public InputFormMessage(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; set; }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Descricao);
        }
    }
}
